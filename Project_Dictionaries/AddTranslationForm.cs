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
    public partial class AddTranslationForm : Form
    {
        string SelectedWord { get; set; }
        public AddTranslationForm(string SelectedWord)
        {
            this.SelectedWord = SelectedWord;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
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
                    this.Close();
                }
                else MessageBox.Show("Введите слово и выберите язык!");
            }
        }
    }
}
