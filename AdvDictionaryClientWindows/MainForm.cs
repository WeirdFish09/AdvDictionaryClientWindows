using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountTransactions;

namespace AdvDictionaryClientWindows
{
    public partial class MainForm : Form
    {
        //delegate Task SafeCall();
        int pageCounter = 0;
        public MainForm()
        {
            InitializeComponent();
            LoginRegisterForm loginRegisterForm = new LoginRegisterForm();
            if(loginRegisterForm.ShowDialog() == DialogResult.OK)
            {
                labelTitle.Text += Controller.GetUsername();
                this.Load += async (sender, e) => { await PopulateLanguages(); };
            }
            else
            {
                this.Load += (sender, e) => { ((MainForm)sender).Close(); };
            }
        }

        private async Task PopulateLanguages()
        {
            RequestWaiting requestWaiting = new RequestWaiting("Receiving languages");
            if (!requestWaiting.IsHandleCreated)
            {
                requestWaiting.CreateControl();
            }
            this.BeginInvoke(new Action(() => requestWaiting.ShowDialog()));
            var languages = await Controller.GetLanguages();
            foreach (var language in languages)
            {
                listBoxLanguages.Items.Add(language.Name);
            }
            requestWaiting.Close();
        }

        private async Task PopulateWordPriorities()
        {
            List<WordPriority> wordPriorities = await Controller.GetWordPriorities(15, 15 * pageCounter, Controller.GetCurrentLanguage().Name);
            dataGridViewWordPriorities.Invoke(new Action(() =>
            {
                dataGridViewWordPriorities.Rows.Clear();
                foreach (var wp in wordPriorities)
                {
                    dataGridViewWordPriorities.Rows.Add(wp.Phrase.Phrase, wp.Value, wp.Word.Word);
                }
                ChangeCellColor();
            }));

        }

        private void ChangeCellColor()
        {
            for(int i = 0; i< dataGridViewWordPriorities.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridViewWordPriorities[1, i].Value.ToString()) >= 10)
                {
                    dataGridViewWordPriorities.Rows[i].Cells[1].Style = new DataGridViewCellStyle() { BackColor = Color.Green };
                }
                if (Convert.ToInt32(dataGridViewWordPriorities[1, i].Value.ToString()) < 10 && Convert.ToInt32(dataGridViewWordPriorities[1, i].Value.ToString()) > -10)
                {
                    dataGridViewWordPriorities.Rows[i].Cells[1].Style = new DataGridViewCellStyle() { BackColor = Color.Yellow };
                }
                if (Convert.ToInt32(dataGridViewWordPriorities[1, i].Value.ToString()) < -10)
                {
                    dataGridViewWordPriorities.Rows[i].Cells[1].Style = new DataGridViewCellStyle() { BackColor = Color.Red };
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ListBox)sender).SelectedItem == null)
            {
                return;
            }
            string language = ((ListBox)sender).SelectedItem.ToString();
            pageCounter = 0;
            Controller.SetCurrentLanguage(language);
            await PopulateWordPriorities();
            await ChangePageNumber();
        }

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            if((pageCounter + 1)*15>=await Controller.GetWordPrioritiesCount())
            {
                return;
            }
            pageCounter++;
            await ChangePageNumber();
            await PopulateWordPriorities();
        }

        private async void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pageCounter == 0)
            {
                return;
            }
            pageCounter--;
            await ChangePageNumber();
            await PopulateWordPriorities();
        }

        private async Task ChangePageNumber()
        {
            int pagesCount = Convert.ToInt32(Math.Ceiling((double)await Controller.GetWordPrioritiesCount() / 15));
            labelPage.Invoke(new Action(() =>
            {
                if (pagesCount == 0) pagesCount++;
                labelPage.Text = (pageCounter + 1) + "/" + pagesCount;
            }));
        }

        private async void buttonAddWordPriority_Click(object sender, EventArgs e)
        {
            CheckLanguageIsSelected();
            ForeignWord foreignWord = new ForeignWord();
            if(foreignWord.ShowDialog() == DialogResult.OK)
            {
                await Controller.AddWordPriorities(foreignWord.wordPriorities);
                await PopulateWordPriorities();
            }
        }

        private async void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            string language = textBoxLanguage.Text.Trim().ToLower();
            if (language == String.Empty)
            {
                MessageBox.Show("Language name can't be blank");
                return;
            };
            listBoxLanguages.Items.Add(language);
            await Controller.AddLanguage(language);
            ClearTextBox(textBoxLanguage);
        }

        private async void dataGridViewWordPriorities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                ForeignWord foreignWord = new ForeignWord(dataGridViewWordPriorities[e.ColumnIndex, e.RowIndex].Value.ToString());
                if(foreignWord.ShowDialog() == DialogResult.OK)
                {
                    await Controller.UpdateWordsPriorities(foreignWord.wordPriorities);
                    await PopulateWordPriorities();
                }
            }
        }

        private async void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestWaiting requestWaiting = new RequestWaiting("Generating Quiz");
            this.BeginInvoke(new Action(() => requestWaiting.ShowDialog()));
            if (Controller.GetCurrentLanguage() == null || await Controller.GetWordPrioritiesCount()<20) return;
            Quiz quiz = new Quiz(await Controller.GenerateQuiz());
            this.Invoke(new Action(() => requestWaiting.Close()));
            quiz.ShowDialog();
            this.Invoke(new Action(() => this.Show()));
            pageCounter = 0;
            await ChangePageNumber();
            await PopulateWordPriorities();
        }

        private async void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            if (Controller.GetCurrentLanguage() == null)
            {
                MessageBox.Show("Select language first");
                return;
            }
            string word = textBoxDeleteWord.Text.Trim().ToLower();
            ClearTextBox(textBoxDeleteWord);
            if (word == string.Empty)
            {
                MessageBox.Show("Foreign word can't be blank");
                return;
            }
            if(!await Controller.ForeignWordExists(word))
            {
                MessageBox.Show("Foreign word doesn't exist");
                return;
            }
            await Controller.DeleteWord(word);
            pageCounter = 0;
            await ChangePageNumber();
            await PopulateWordPriorities();
        }

        private async void buttonRenameWord_Click(object sender, EventArgs e)
        {
            if (Controller.GetCurrentLanguage() == null)
            {
                MessageBox.Show("Select language first");
                return;
            }
            string originalWord = textBoxOriginalWord.Text.Trim().ToLower();
            if (originalWord == string.Empty)
            {
                MessageBox.Show("Original word can't be blank");
                return;
            }
            string newWord = textBoxNewWord.Text.Trim().ToLower();
            if (newWord == string.Empty)
            {
                MessageBox.Show("New word can't be blank");
                return;
            }
            if(!await Controller.ForeignWordExists(originalWord))
            {
                MessageBox.Show("Foreign word doesn't exist");
                return;
            }
            if (await Controller.ForeignWordExists(newWord))
            {
                MessageBox.Show("Foreign word already exist");
                return;
            }
            await Controller.RenameWord(originalWord, newWord);
            pageCounter = 0;
            await ChangePageNumber();
            await PopulateWordPriorities();
            ClearTextBox(textBoxOriginalWord);
            ClearTextBox(textBoxNewWord);
        }

        private void CheckLanguageIsSelected()
        {
            if (Controller.GetCurrentLanguage() == null)
            {
                MessageBox.Show("Select language first");
            }
        }

        private async Task ChangeSortingVariant(SortingVariants sortingVariant)
        {
            if (Controller.GetCurrentLanguage() == null)
            {
                MessageBox.Show("Choose Language first");
                return;
            }
            Controller.SetSortingVariant(sortingVariant);
            pageCounter = 0;
            await ChangePageNumber();
            await PopulateWordPriorities();
        }

        private async void byPriorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeSortingVariant(SortingVariants.Priority);
        }

        private async void byNativePhraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeSortingVariant(SortingVariants.NativePhrase);
        }

        private async void byForeignWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeSortingVariant(SortingVariants.ForeignWord);
        }

        private async void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ChangeSortingVariant(SortingVariants.Id);
        }

        private void ClearTextBox(TextBox textBox)
        {
            textBox.Invoke(new Action(() => textBox.Text = ""));
        }
    }
}
