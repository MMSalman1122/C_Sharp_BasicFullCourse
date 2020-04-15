using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1=0;
            double num2=0;
            char opperator;
            double result=0;

            Console.WriteLine("Enter the first number: \n");
            num1=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the second number: \n");
            num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter operator: \n");
            opperator =Convert.ToChar(Console.ReadLine());

            if (opperator =='+')
            {
                result = num1 + num2;
            }
            else if (opperator == '-')
            {
                result = num1 - num2;
            }
            else if (opperator == '*')
            {
                result = num1 * num2;
            }
            else if (opperator=='/')
            {
                try
                {
                    result = num1 / num2;
                }
                catch(Exception)
                {
                    Console.WriteLine("Division is not possible.");
                }
            }
            else
            {
                Console.WriteLine("Enter valid opperator.");
            }

            Console.WriteLine(result);
            while (true)
            { }
            
        }
    }
}
