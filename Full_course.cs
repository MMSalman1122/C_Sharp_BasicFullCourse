using System;
using System.Collections.Generic;

namespace test
{

    class Program
    {
        public static void Main()
        {
            var sentence = "This is very very very very very very very very very very very very very very very very very very very long line";
            var summary = summarizeText(sentence);
            Console.WriteLine(summary);
            Console.ReadLine();            
        }

        static string summarizeText(string text, int maxLength=20)
        { 

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {

                var words = text.Split(' ');
                var totalChar = 0;
                var summaryword = new List<string>();
                foreach (var word in words)
                {
                    summaryword.Add(word);
                    totalChar += word.Length + 1;
                    if (totalChar > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", summaryword) + "...";

            }
        }
     
    }
}
