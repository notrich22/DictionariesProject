using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dictionaries
{
    public class dictionary
    {
        private List<Word> words;
        private const string filename = "Words.txt";
        public List<Word> GetWords()
        {
            return words;
        }
        public dictionary()
        {
            words = new List<Word>();
            ReadFromFile();
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
        public bool SaveToFile(string filename = filename)
        {
            try
            {
                if(GetWords().Count != File.ReadAllLines(filename).Length){
                    StreamWriter sw = new StreamWriter(filename, false);
                    sw.WriteLine(ToString());
                    sw.Close();
                    return true; }
                return false;
            }catch (Exception ex) { return false; }
        }
        public bool ReadFromFile(string filename = filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (!String.IsNullOrEmpty(parts[0]))
                        addWord(parts[0]);
                    for(int i = 1; i < parts.Count()-1; i+=2)
                    {
                        SetTranslation(parts[0], parts[i], parts[i+1]);
                    }
                }
                sr.Close();
                return true;
            }
            catch(Exception e) {return false; }
            }
    }
}
