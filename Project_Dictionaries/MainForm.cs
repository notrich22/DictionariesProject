using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Dictionaries
{
    public partial class MainForm : Form
    {
        public dictionary dict = null;
        public MainForm()
        {
            dict = new dictionary();
            InitializeComponent();
        }
        private void refresh()
        {
            LanguagesCheckBox.Visible = false;
            WordsBox.Items.Clear();
            TranslationsBox.Items.Clear();
            foreach(Word word in dict.GetWords())
            {
                WordsBox.Items.Add(word.wordOnRussian);
            }
        }
        private void WordsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WordsBox.SelectedIndex != -1)
            {
                TranslationsBoxRefresh();
            }
        }
        private void TranslationsBoxRefresh()
        {
            LanguagesCheckBox.Items.Clear();
            LanguagesCheckBox.Visible = true;
            TranslationsBox.Items.Clear();
            foreach (string key in dict.FindByWOR(WordsBox.SelectedItem.ToString()).Translations.Keys)
            {
                LanguagesCheckBox.Items.Add(key);
            }
            for (int i = 0; i < LanguagesCheckBox.Items.Count; i++)
                LanguagesCheckBox.SetItemChecked(i, true);
            TranslationsBoxPrint();
        }
        private void TranslationsBoxPrint()
        {
            foreach (KeyValuePair<string, string> translation in dict.FindByWOR(WordsBox.SelectedItem.ToString()).Translations)
            {
                string format = $"{translation.Key}: {translation.Value}";
                if(LanguagesCheckBox.CheckedItems.Contains(translation.Key))
                    TranslationsBox.Items.Add(format);
            }
        }

        private void LanguagesCheckBox_Click(object sender, EventArgs e)
        {
            TranslationsBoxRefresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                dict.addWord(WordTextBox.Text);
                WordsBox.Items.Add(WordTextBox.Text);
            }
            else MessageBox.Show("Введите слово!");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dict.SaveToFile();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dict.RemoveWordByWOR(WordsBox.SelectedItem.ToString());
            WordsBox.Items.Remove(WordsBox.SelectedItem.ToString());
        }

        private void AddTranslationButton_Click(object sender, EventArgs e)
        {
            if (WordsBox.SelectedIndex != -1)
            {
                Form TranslationForm = new AddTranslationForm(WordsBox.SelectedItem.ToString());
                TranslationForm.Owner = this;
                TranslationForm.ShowDialog();
                TranslationsBoxPrint();
            }
            else MessageBox.Show("Выберите слово чтобы добавить перевод!");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            refresh();
        }

        private void DeleteTranslationButton_Click(object sender, EventArgs e)
        {
            dict.FindByWOR(WordsBox.SelectedItem.ToString()).DeleteByLanguage(TranslationsBox.SelectedItem.ToString().Split(':')[0]);
            TranslationsBox.Items.Remove(TranslationsBox.SelectedItem.ToString());
        }
    }
}
