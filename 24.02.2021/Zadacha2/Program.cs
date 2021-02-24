using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete dvoichno chislo = ");
            string chislo = Console.ReadLine();
            int chislo10 = Convert.ToInt32(chislo, 2);
            Console.WriteLine("Vuvedete dvoichno chislo = ");
            string chislo2 = Console.ReadLine();
            int chislo210 = Convert.ToInt32(chislo2, 2);
            int sum = chislo10 + chislo210;
            string sum2 = Convert.ToString(sum, 2);
            Console.WriteLine(sum2);
        }
    }
}
