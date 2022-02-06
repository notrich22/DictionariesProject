using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Dictionaries
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        //[STAThread]
        static void TESTFUNC()
        {
            dictionary dict = new dictionary();
            /*for (int i = 0; i < 10; i++)
            {
                dict.addWord($"{i}");
                dict.SetTranslation($"{i}", "ru", $"{i}{i}{i}");
            }*/
            const string filename = "test.txt";
            dict.ReadFromFile(filename);
            Console.WriteLine(dict);
            Console.ReadLine();
            Console.WriteLine(dict);
            Console.WriteLine(dict.FindByWOR($"3"));
            Console.WriteLine(dict.FindByWOR($"0").GetTranslationByLanguage("eng"));
            dict.RemoveWordByWOR("2");
            Console.WriteLine(dict);
            dict.SaveToFile(filename);
            Console.ReadLine();
            dict.ReadFromFile(filename);
            Console.ReadLine();
        }
        static void Main()
        {
            /* Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Form1());*/
            TESTFUNC();
        }
    }
}
