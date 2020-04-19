using System;

namespace test
{

    class Program
    {
        var timeSpan = new TimeSpan(1, 2, 3);
        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;
        Console.WriteLine (duration);
     
    }
}
