using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Dictionaries
{
    public partial class AddTranslationForm : Form
    {
        string SelectedWord { get; set; }
        const string LanguagesFilename = "Languages.txt";
        public AddTranslationForm(string SelectedWord)
        {
            this.SelectedWord = SelectedWord;
            InitializeComponent();
        }
        private void SaveLanguages()
        {
            try
            {
                int SavedLanguagesCount = File.ReadAllText(LanguagesFilename).Split(':').Length-1;
                if (LanguageBox.Items.Count != SavedLanguagesCount)
                {
                    StreamWriter sw = new StreamWriter(LanguagesFilename, false);
                    foreach (var item in LanguageBox.Items)
                    {
                        sw.Write($"{item.ToString()}:");
                    }
                    sw.Close();
                }
            }
            catch (Exception ex) { return; }
        }
        private void InitializeLanguages()
        {
            try
            {
                StreamReader sr = new StreamReader(LanguagesFilename);
                string line = sr.ReadLine();
                if (!String.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split(':');
                    for (int i = 0; i < parts.Count(); i ++)
                    {
                        if (!String.IsNullOrEmpty(parts[i]))
                            LanguageBox.Items.Add(parts[i]);
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { return; }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            SaveLanguages();
            this.Close();
        }

        private void AddTranslationButton_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (LanguageBox.SelectedItem != null && (TranslationBox.Text != "" && TranslationBox.Text != " "))
                {
                    main.dict.SetTranslation(SelectedWord, LanguageBox.Text, TranslationBox.Text);
                    SaveLanguages();
                    this.Close();
                }
                else MessageBox.Show("Введите слово и выберите язык!");
            }
        }

        private void AddLanguagesButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TranslationBox.Text))
            {
                LanguageBox.Items.Add(TranslationBox.Text);
            }
            else MessageBox.Show("Введите язык для добавления!");
        }

        private void DeleteLanguageButton_Click(object sender, EventArgs e)
        {
            if (LanguageBox.SelectedItem != null)
            {
                LanguageBox.Items.Remove(LanguageBox.SelectedItem);
                SaveLanguages();
            }
        }
        private void AddTranslationForm_Load(object sender, EventArgs e)
        {
            InitializeLanguages();
        }
    }
}
