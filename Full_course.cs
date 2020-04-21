using System;
using System.Collections.Generic;

namespace test
{

    class Program
    {
        public static void Main()
        {
            var sentence = "This is very very very very very very very very very very very very very very very very very very very long line";

            const int maxLength = 20;

            if (sentence.Length<maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                
                var words = sentence.Split(' ');
                var totalChar = 0;
                var summaryword = new List<string>();
                foreach(var word in words)
                {
                    summaryword.Add(word);
                    totalChar += word.Length + 1;
                    if(totalChar>maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryword) + "...";
                Console.WriteLine(summary);
                Console.ReadLine();

            }
        }
     
    }
}
