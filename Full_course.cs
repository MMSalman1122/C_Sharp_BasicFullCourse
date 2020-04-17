using System;
using System.Collections.Generic;
namespace test
{

    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>() { 1,2,3,4};
            num.Add(1);
            num.AddRange(new int[3] { 5,6,7});

            foreach(var a in num)
                Console.WriteLine(a);

            Console.ReadLine();

        }
    }
}
