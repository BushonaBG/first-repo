using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете десетично число");
            int chislo = int.Parse(Console.ReadLine());
            string dvuichno = Convert.ToString(chislo,2);
            Console.WriteLine("Двуичното число е: {0}",dvuichno);
        }
    }
}
