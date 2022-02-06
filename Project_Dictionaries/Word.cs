using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dictionaries
{
    public class Word
    {
        public string wordOnRussian { get; set; }
        private Dictionary<string, string> translations{get;set;}
        public Dictionary<string, string> Translations { get { return translations; } set { } }
        public Word(string wordOnRussian)
        {
            this.wordOnRussian = wordOnRussian;
            translations = new Dictionary<string, string>();
        }
        public string GetTranslationByLanguage(string language)
        {
            return translations.ContainsKey(language) ? translations[language] : null;
        }
        public void SetTranslation(string language, string word) // Добавление и редактирование перевода
        {
            translations[language] = word;
        }
        public string DeleteByLanguage(string language)
        {
            if (translations.ContainsKey(language)) {
                string res = translations[language];
                translations.Remove(language);
                return res;
            }
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.wordOnRussian + ":");
            foreach(KeyValuePair<string, string> pair in translations)
                sb.Append(pair.Key + ':' + pair.Value + ':');
            return sb.ToString();
        }
    }
}
