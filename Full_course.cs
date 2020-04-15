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
            // strurcture are valure type
            var num1 = 2;
            var num2 = num1;
            num2++;

            Console.WriteLine("num1:{0}, num2:{1}", num1,num2);

            // classes are reference type

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[2] = 0;

            Console.WriteLine("arr1[2]:{0}, arr2[2]:{1}", array1[2], array2[2]);

            while (true)
            {

            }
        }
    }
}
