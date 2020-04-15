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
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0] + numbers[1] + numbers[2]);

            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            string FirstName = "Salm";
            String LastName = "Ali";
            Console.WriteLine(FirstName[2]);

            string name = string.Format("{1} {0}", FirstName, LastName);
            Console.WriteLine(name);

            string name1 = string.Format("{0} {1}", FirstName, LastName);
            Console.WriteLine(name1);

            while (true)
            {

            }
        }
    }
}
