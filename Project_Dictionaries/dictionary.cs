using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dictionaries
{
    internal class dictionary
    {
        private List<Word> words;
        public dictionary()
        {
            words = new List<Word>();
        }
        public void addWord(string WOR)
        {
            words.Add(new Word(WOR));    
        }
        public Word SetTranslation(string WOR,string language, string translation)
        {
            Word word = FindByWOR(WOR);
            if (word != null)
            {
                word.SetTranslation(language, translation);
                return word;
            }
            return null;
        }
        public Word FindByWOR(string wor)
        {
            foreach(Word word in words)
            {
                if(word.wordOnRussian == wor) { return word; }
            }
            return null;
        }
        public void RemoveWordByWOR(string WOR)
        {
            words.Remove(FindByWOR(WOR));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Word word in words)
                sb.Append(word.ToString() + "\n");
            return sb.ToString();
        }
        public bool SaveToFile(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(ToString());
                sw.Close();
                return true;
            }catch (Exception ex) { return false; }
        }
        public bool ReadFromFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    addWord(parts[0]);
                    for(int i = 1; i < parts.Count(); i++)
                    {
                        if(i%2 != 0)
                        {
                            SetTranslation(parts[0], parts[i], parts[i+1]);
                        }
                    }
                }
                return true;
            }catch(Exception e) {return false; }
            }
    }
}
