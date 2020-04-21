using System;
using System.Collections.Generic;
using System.Text;

namespace test
{

    class Program
    {
        public static void Main()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);


            builder.Replace('-', '+');
            Console.WriteLine(builder);
            builder.Remove(0,10);
            Console.WriteLine(builder);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            var builder1 = new StringBuilder("Hello world");
            builder1.AppendLine();
            builder1.Append('-', 10);
            Console.WriteLine(builder1);

            Console.ReadLine();
        }
     
    }
}
