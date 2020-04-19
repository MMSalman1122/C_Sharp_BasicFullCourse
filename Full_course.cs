using System;

namespace test
{

    class Program
    {
        var dateTime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;


        Console.WriteLine("Hour:" + now.Hours);
        Console.WriteLine("Minute: " + now.Minute); 
     
    }
}
