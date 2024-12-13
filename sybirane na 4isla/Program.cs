using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sybirane_na_4isla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var i = 1;
            var s = 1;
            var a = 1;
            do
            {    
             s = n /1000;
             i = n %1000/100;
             a= n %10;

            }
            while (n < 0);
            Console.WriteLine("sum of digits:{0}",i);
            Console.WriteLine("sum of digits:{0}",s);
            Console.WriteLine("sum of digits:{0}",a);
        }
    }
}
