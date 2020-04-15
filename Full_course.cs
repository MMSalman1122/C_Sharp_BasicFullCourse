using System;

namespace HelloWorld
{
    public class Hello
    {
        public static void Main()
        {
            Console.WriteLine("Hi");
            byte number=10;
            int a=2;
            float price=15.20f;
            char c='d';
            string name="mimi";
            bool isWorking = false;
            var a1=6;
            var name2="mimi1";
            const float pi=3.14;
        
            Console.WriteLine(number);
            Console.WriteLine(price);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);
            Console.WriteLine(a1);
            Console.WriteLine(name2);
            Console.WriteLine("{0} {1}", float.MinValue,float.MaxValue);//string formate.
        }
       
    }
}