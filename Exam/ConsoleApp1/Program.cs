using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    enum DelimiterChars
    {
        Space = ' ',
        Dot = '.',
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
        



        public WordFrequence() { }

        public WordFrequence(string[] _word)
        {
            
            word = _word;
            count++;
        }

        public string GetWord()
        {
            //string bigText = "A snowflake is a single ice crystal that has achieved a sufficient size and may have amalgamated with others," +
            //                    " and that falls through the Earth's atmosphere as snow.";

            char[] c1;
           
            try
            {
                c1 = (char[])Enum.GetValues(typeof(DelimiterChars));
                string[] words = bigText.Split(c1, StringSplitOptions.RemoveEmptyEntries);
                words = bigText.Split(c1);

                word = words[0];
                
            }
            catch (Exception c)
            {
                WriteLine(c.Message);
            }

            return word;
        }

        public static uint operator++()
        {
            //доделать
            return count++;
        }
        
        public uint GetWordCount
        {
            get
            { return count; }
        }

        public override string ToString()
        {
            string s = 
            //Доделать ТоСтринг
            return s;
        }
        
        
    
    }

    class DictionaryFrequence : WordFrequence
    {
        Dictionary<string, int> AW;
        int WordCount;

        public DictionaryFrequence()
        {
            AW = new Dictionary<string, int>();
        }

        public void ReadFromFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    bigText = sr.ReadLine();

                    foreach (string word in words)
                    {
                        if (wordCounts.ContainsKey(word))
                        {
                            wordCounts[word]++;
                        }
                        else
                        {
                            wordCounts[word] = 1;
                        }
                    }
                    AW.Add(GetWord(), Convert.ToInt32(GetWordCount));
                }
            }   
        }

        public void SaveResultsToFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                     bigText = sw.ToString();
                }
            }
        }

        public void Print()
        {
            foreach (var word in AW)
            {
                WriteLine("{0}-{1}", word.Key, word.Value + ";");
            }
        }

        public WordFrequence[] ToWordFrequence()
        {
            WordFrequence[] wordFrequences = new WordFrequence[AW.Count];
            for (int i = 0; i<wordFrequences.Length; i++)
                wordFrequences[i] =  AW.Keys + AW.Values;
        }
    }
        
    
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            WordFrequence wordFrequence = new WordFrequence();
            DictionaryFrequence dictionaryFrequence = new DictionaryFrequence();

            string sempl = "A snowflake is a single ice crystal that has achieved a sufficient size and may have amalgamated with others, and that falls through the Earth's atmosphere as snow."


            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }


            public string[] word2;
            public string bigText;
            public string bigTex2;


            

        }
    }
}

class Program
{
    static void Main()
    {
        char[] delimiters = { ' ', ',', '.', ';', ':', '-', '\n', '\r' };
        string text = File.ReadAllText("myfile.txt");
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }
        foreach (KeyValuePair<string, int> pair in wordCounts)
        {
            Console.WriteLine("word: {0}, count:{1}", pair.Key, pair.Value);
        }
    }
}