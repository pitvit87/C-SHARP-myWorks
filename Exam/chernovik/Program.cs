using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp1
{
    //enum DelimiterChars
    //{
    //    Space = ' ',
    //    Dot = '.',
    //    Semicolon = ';',
    //    NewLine = '\n'
    //};

    //interface IWord
    //{
    //    string GetWord();
    //    uint GetWordCount { get; }
    //}

    //class WordFrequence : IWord
    //{
    //    private string word;
    //    private uint count;
    //    public DelimiterChars delim;
    //    // public char[] AC = Enum.GetValues(typeof(char)DelimiterChars); 



    //    public WordFrequence()
    //    { }

    //    public WordFrequence(string _word)
    //    {
    //        word = _word;
    //    }

    //    public string GetWord()
    //    {
    //        string bigText = "A snowflake is a single ice crystal that has achieved a sufficient size and may have amalgamated with others," +
    //                            " and that falls through the Earth's atmosphere as snow.";
    //        string word2;
    //        int index = 0;
    //        char c1;
    //        char[] c2;
    //        //System.Enum[] enums = { DelimiterChars.Space, DelimiterChars.Dot, DelimiterChars.Semicolon, DelimiterChars.NewLine };
    //        DelimiterChars delim;

    //        foreach (char t in bigText)
    //        {
    //            c1 = t;
    //            try
    //            {
    //                c2 = (char[])Enum.GetValues(typeof(DelimiterChars));

    //                if (Enum.IsDefined(typeof(DelimiterChars), (char)t))
    //                {

    //                }
    //                else
    //                {
    //                    = Enum.GetValues(typeof(DelimiterChars));
    //                    index = bigText.LastIndexOfAny(c2);
    //                    index++;
    //                    bigText.
    //                }


    //            }
    //            catch (Exception c)
    //            {
    //                WriteLine(c.Message);


    //            }
    //        }

    //    }

    //    public uint GetWordCount
    //    {
    //        get
    //        { return count; }
    //    }


    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string bigText = "Загальна кількість слів у файлі: N";
            string[] word2;
            char[] c1 = { ' ', '.', ',', ';' };
            //int index = bigText.LastIndexOfAny(c1);
            WriteLine(bigText);
            WriteLine("---------------------------");
            //WriteLine(index);
            word2 = bigText.Split(c1);
            WriteLine("---------------------------");
            foreach (string c in word2)
            {
                WriteLine(c);

            }

            ReadKey();
        }
    }
}
