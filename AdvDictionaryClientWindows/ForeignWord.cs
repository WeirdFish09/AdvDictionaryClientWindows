﻿using System;
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
    public partial class ForeignWord : Form
    {
        string foreignWord = "";
        List<WordPriority> wordPriorities = new List<WordPriority>();
        public ForeignWord()
        {
            InitializeComponent();
        }

        public ForeignWord(string foreignword)
        {
            InitializeComponent();
            textBoxForeignWord.Text = foreignword;
            textBoxForeignWord.ReadOnly = true;
            labelTitle.Text = "Change Priority";
            buttonRemovePhrase.Click -= buttonRemovePhrase_Click;
            buttonRemovePhrase.Click += buttonRemovePhrase_Click2;
            foreignWord = foreignword;
            this.Load += OnLoad;
            buttonOK.Click -= buttonOK_Click;
            buttonOK.Click += buttonOK2_Click;
            labelCurrentForeignWord.Text = "Current foreign word - " + foreignWord;
        }

        private async Task PopulatePhrases(string foreignword)
        {
            wordPriorities = await Controller.GetTranslations(foreignword);
            foreach (var wp in wordPriorities)
            {
                listBoxNativePhrases.Items.Add(wp.Phrase.Phrase);
            }
        }
        private void buttonChangePriority_Click(object sender, EventArgs e)
        {
            if(listBoxNativePhrases.SelectedItem == null)
            {
                MessageBox.Show("Please select nartive phrase");
                return;
            }
            int priority = Convert.ToInt32(maskedTextBoxSetPriority.Text);
            string nativePhrase = listBoxNativePhrases.SelectedItem.ToString();
            wordPriorities.Where(wp => wp.Phrase.Phrase == nativePhrase).Single().Value = priority;
            labelPriority.Text = "Current Priority - " + priority;
        }

        private void buttonNativePhrase_Click(object sender, EventArgs e)
        {
            string nativePhrase = textBoxNativePhrase.Text.Trim().ToLower();
            if (listBoxNativePhrases.Items.Contains(nativePhrase))
            {
                MessageBox.Show("Phrase already added");
                return;
            }
            listBoxNativePhrases.Items.Add(nativePhrase);
            NativePhrase phrase = new NativePhrase() { Phrase = nativePhrase };
            WordPriority wordPriority = new WordPriority() { Phrase = phrase, Language = Controller.GetCurrentLanguage(), Value = 0 };
            wordPriorities.Add(wordPriority);
        }

        private void buttonRemovePhrase_Click(object sender, EventArgs e)
        {
            string nativePhrase = textBoxNativePhrase.Text.Trim().ToLower();
            if (!listBoxNativePhrases.Items.Contains(nativePhrase))
            {
                MessageBox.Show("Phrase doesn't exist");
                return;
            }
            listBoxNativePhrases.Items.Remove(nativePhrase);
            wordPriorities.Remove(wordPriorities.Where(wp => wp.Phrase.Phrase == nativePhrase).Single());
        }

        private void buttonRemovePhrase_Click2(object sender, EventArgs e)
        {
            string nativePhrase = textBoxNativePhrase.Text.Trim().ToLower();
            if (!listBoxNativePhrases.Items.Contains(nativePhrase))
            {
                MessageBox.Show("Phrase doesn't exist");
                return;
            }
            if(listBoxNativePhrases.Items.Count == 1)
            {
                MessageBox.Show("You need at least one translation");
                return;
            }
            listBoxNativePhrases.Items.Remove(nativePhrase);
            wordPriorities.Remove(wordPriorities.Where(wp => wp.Phrase.Phrase == nativePhrase).Single());
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            if (foreignWord == String.Empty)
            {
                MessageBox.Show("Please insert foreign word");
                return;
            }
            if (listBoxNativePhrases.Items.Count == 0)
            {
                MessageBox.Show("Please insert at least one translation");
                return;
            }
            foreach(var wp in wordPriorities)
            {
                wp.Word = new AccountTransactions.ForeignWord() { Word = foreignWord };
            }
            await Controller.AddWordPriorities(wordPriorities);
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void buttonOK2_Click(object sender, EventArgs e)
        {
            await Controller.UpdateWordsPriorities(wordPriorities);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBoxNativePhrases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxNativePhrases.SelectedItem == null)
            {
                return;
            }
            labelPriority.Text = "Current Priority - " + wordPriorities.Where(wp => wp.Phrase.Phrase == listBoxNativePhrases.SelectedItem.ToString()).Single().Value;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            await PopulatePhrases(foreignWord);
        }

        private void buttonAddForeignWord_Click(object sender, EventArgs e)
        {
            foreignWord = textBoxForeignWord.Text;
            labelCurrentForeignWord.Text = "Current foreign word - " + foreignWord; 
        }
    }
}
