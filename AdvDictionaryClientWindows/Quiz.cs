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
    public partial class Quiz : Form
    {
        private List<WordPriority> wordPriorities;
        private string[] answers;
        private int wordCounter = 0;
        public Quiz(List<WordPriority> wordPriorities)
        {
            this.wordPriorities = wordPriorities;
            answers = new string[wordPriorities.Count];
            InitializeComponent();
            UpdateWord();
        }

        private async void buttonFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] != wordPriorities[i].Word.Word)
                {
                    wordPriorities[i].Value = wordPriorities[i].Value < -29 ? -30 : wordPriorities[i].Value - 1;
                }
                else
                {
                    wordPriorities[i].Value = wordPriorities[i].Value > 29 ? 30 : wordPriorities[i].Value + 1;
                }
            }
            DialogResult = DialogResult.OK;
            await Controller.SubmitQuiz(wordPriorities);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (wordCounter == 0) return;
            wordCounter--;
            UpdateWord();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (wordCounter + 1 == wordPriorities.Count) return;
            wordCounter++;
            UpdateWord();
        }

        private void UpdateWord()
        {
            labelWordCount.Text = (wordCounter + 1) + "/" + wordPriorities.Count;
            labelNativePhrase.Text = wordPriorities[wordCounter].Phrase.Phrase;
            if (answers[wordCounter] != null)
            {
                labelCurrentAnswer.Text = "Current answer - " + answers[wordCounter];
                labelCurrentAnswer.Visible = true;
            }
            else
            {
                labelCurrentAnswer.Visible = false;
            }
        }

        private void buttonSetForeignWord_Click(object sender, EventArgs e)
        {
            string word = textBoxForeignWord.Text.Trim().ToLower();
            answers[wordCounter] = word;
            UpdateWord();
        }
    }
}
