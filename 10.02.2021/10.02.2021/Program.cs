using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма която чете средният успех на учениците от една група и извжда на класът
            Console.WriteLine("Колко ученици има?");
            int n = int.Parse(Console.ReadLine());
            double obshto;
            double suma = 0;
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("Въведете успеха: ");
                double u = double.Parse(Console.ReadLine());
                suma = suma + u;
            }
            obshto = suma / n;
            Console.WriteLine("Общият успех е:{0:f2}",obshto);
        }
    }
}
