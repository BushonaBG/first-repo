using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashno_27._09
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo = "18";
            int desetichno = Convert.ToInt32(chislo, 16);
            string dvuichno = Convert.ToString(desetichno, 2);
            Console.WriteLine(dvuichno);
        }
    }
}
