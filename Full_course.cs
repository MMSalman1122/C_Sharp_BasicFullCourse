using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public enum ShippingMethod
    {
        Regular=1,
        Registered=2,
        Express=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            Console.WriteLine(method);

            // method to number
            Console.WriteLine((int)method);

            // number to method
            var num = 3;
            Console.WriteLine((ShippingMethod)num);

            //metho to string
            Console.WriteLine(method.ToString());

            //parsing
            var method_name = "Express";
            var ShippingMethod1=(ShippingMethod)Enum.Parse(typeof(ShippingMethod), method_name);

            while (true)
            {

            }
        }
    }
}
