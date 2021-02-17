using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi dvoichno chislo: ");
            string bin = Console.ReadLine();
            int dec = Convert.ToInt32(bin, 2);
            Console.WriteLine("Desetichnoto: " + dec);
            Console.WriteLine("Dvoichno: " + bin);
        }
    }
}
