using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{

    class Program
    {
        public static void Main()
        {
            Directory.CreateDirectory(@"C:\temp\folder1");

            var files=Directory.GetFiles(@"C:\temp\folder1" , "*,*" ,SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadLine();
        }
     
    }
}