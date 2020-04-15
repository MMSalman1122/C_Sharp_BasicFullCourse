using System;

namespace HelloWorld
{
    public class Hello
    {
        public static void Main()
        {
            byte a=1;
            int b=a;
            Console.WriteLine(b);
            
            int c=1;
            byte d= (byte)c;
            Console.WriteLine(d);
            
            byte num3=255;
            num3 +=2; 
            Console.WriteLine(num3); //=1 shows overflow
            
            var num="1234";
            int e=Convert.ToInt32(num);
            Console.WriteLine(e);
            
            //without try catch it overflows and app crashes.
            try
            {
                byte f=Convert.ToByte(num); 
                Console.WriteLine(f);
            }
            catch (Exception)
            {
                Console.WriteLine("No cant be converted");
            }
            
        }
    }
}