using System;
using classes.math;
namespace classes
{   public class cal
    {   
        public void sum(int a, int b)
        {

            Console.WriteLine("Sum is:" + (a + b));
        }
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void intro()
        {
            Console.WriteLine("First name " + FirstName + " " + "Last Name " + LastName);
        }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Salman";
            p1.LastName = "Ali";
            p1.intro();

            cal obj = new cal();
            obj.sum(3, 8);
            
            while(true)
            {

            }
        }
    }
}
