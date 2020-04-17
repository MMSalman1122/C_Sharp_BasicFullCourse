using System;
namespace test
{

    class Program
    {
        static void Main(string[] args)
        {
            var num = new [] {3,7,9,14,6 };

            Console.WriteLine("Length:" + num.Length);
            var index=Array.IndexOf(num, 9);
            Console.WriteLine(index);

            Array.Clear(num, 0, 2);
            Console.WriteLine("arr[0]:{0},arr[2]:{1}", num[0], num[1]);
            int [] num2 = new int [3];
            Array.Copy(num,num2,3);
            foreach(var a in  num2)
            {
                Console.WriteLine(a);
            }
            Array.Sort(num);
            foreach (var a in num)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
    }
}
