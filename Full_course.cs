using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    public enum Seasons
    {
        Spring,
        Summer,
        Automun,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season1 = Seasons.Automun;
            
            switch(season1)
            {
                case Seasons.Automun:
                    Console.WriteLine("Its beautiful season.");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("go to beach");
                    break;
                default:
                    Console.WriteLine("No season");
                    break;
                
            }
            

            while (true)
            {

            }
        }
    }
}
