using System;

namespace test
{

    class Program
    {
        public static void Main()
        {
            var fullName = "Salman Ali ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name:{0}, Last Name:{1}", firstName,lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First:"+ names[0]);
            Console.WriteLine("Second:"+ names[1]);

            Console.WriteLine(fullName.Replace("Salman", "maan"));


            if(String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");

            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age =Convert.ToSByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            Console.ReadLine();
        }
     
    }
}
