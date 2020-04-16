using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for(var i=0; i<5;i++)
            {
                Console.WriteLine(random.Next()); 
            }
            
        }
    }
}
