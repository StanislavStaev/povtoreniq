using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vyvedi 4islo  ");
            int P = 1;
            int n = int .Parse(Console.ReadLine()); 
            do
            {
                P = P * n;
                n--;
            }
            while (n >1);
            Console.WriteLine("P="+P);
        }
    }
}
