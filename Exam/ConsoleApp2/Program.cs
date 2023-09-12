using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    enum DelimiterChars
    {
        Space = ' ',
        Dot = '.',
        Comma = ',', //додав кому, ну як без коми))
        Semicolon = ';',
        NewLine = '\n'
    };

    interface IWord
    {
        string GetWord();
        uint GetWordCount { get; }
    }

    class WordFrequence : IWord
    {
        private string word;
        private uint count;

        public WordFrequence(string _word)
        {
            this.word = _word;
            count = 0;
        }

        public string GetWord()
        {
            return word;
        }

        public uint GetWordCount
        {
             get { return count; }
        }

        public override string ToString()
        {
            string s = "Слово: " + word + " - " + count + "\n";
            return s;
        }

        public static WordFrequence operator++(WordFrequence obj)
        {
            obj.count++;
            return obj;
        }
    }

    class DictionaryFrequence
    {
        Dictionary<string, int> AW;


        public DictionaryFrequence()
        {
            AW = new Dictionary<string, int>();
        }

        public void ReadFromFile(string filename)
        {
            try
            {
                string bigText;
                
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        bigText = sr.ReadToEnd();
                    }
                }

                //char[] c1 = (char[])Enum.GetValues(typeof(DelimiterChars)); //не спрацювало!!!(((
                
                string[] words = bigText.Split(ArrayDelimiters(), StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (AW.ContainsKey(word))
                    {
                        AW[word]++;
                    }
                    else
                    {
                        AW.Add(word, 1);
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        public char[] ArrayDelimiters()
        {
            char[] c1 = {
                        (char)DelimiterChars.Space,
                        (char)DelimiterChars.NewLine,
                        (char)DelimiterChars.Comma,
                        (char)DelimiterChars.Semicolon,
                        (char)DelimiterChars.Dot
                        };
            return c1;
        }

        public void SaveResultsToFile(string filensme)
        {
            try
            {
                using(FileStream fs = new FileStream(filensme, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        int i = 1;
                        int sumWord = AW.Sum(wc => wc.Value);
                        sw.WriteLine("Загальна кількість слів у файлі: " + sumWord);
                        foreach (var wc in AW)
                        {
                            sw.WriteLine("слово" + i + " " + wc.Key + " : " + wc.Value);
                            i++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }   
        }
        public void Print(string msg)
        {
            WriteLine(msg + " => ");
            foreach(var wc in AW)
            {
                WriteLine("{0} : {1}", wc.Key, wc.Value);
            }
            WriteLine();
        }

        public WordFrequence[] ToWordFrequence()
        {
            WordFrequence[] twf = new WordFrequence[AW.Count];
            int index = 0;
            foreach(var wc in AW)
            {
                WordFrequence wf = new WordFrequence(wc.Key);
                for (int i = 0; i < wc.Value; i++)
                {
                    wf++;
                }
                twf[index] = wf;
                index++;
            }
            return twf;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            DictionaryFrequence dictionaryFrequence = new DictionaryFrequence();
            dictionaryFrequence.ReadFromFile("file.txt");
            dictionaryFrequence.SaveResultsToFile("resultFile.txt");
            dictionaryFrequence.Print("pair in text");
            WordFrequence[] wf = dictionaryFrequence.ToWordFrequence();


            WriteLine("--------------------------");
            WriteLine();
            foreach(WordFrequence wc in wf)
            {
                Write(wc);
                
            }

        
            ReadKey();
        }
    }
}
