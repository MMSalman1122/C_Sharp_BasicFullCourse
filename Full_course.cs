using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=0; i <= 10;i++)
            {
                if (i % 2==0)
                {
                    Console.WriteLine(i);
                }
            }
            for (var i=10; i>=0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            var name = "Salman Ali";
            for (var i=0 ; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach (var charac in name)
            {
                Console.WriteLine(charac);
            }
            var check = 0;

            while (check<=10)
            {
                if (check % 2 == 0)
                {
                    Console.WriteLine(check);
                }
                check++;
            }
            
            while(true)
            {
                Console.WriteLine("Enter your name :");
                var input =Console.ReadLine();

                //if enter
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo : " + input);
            }

            while (true)
            {

            }
        }
    }
}
