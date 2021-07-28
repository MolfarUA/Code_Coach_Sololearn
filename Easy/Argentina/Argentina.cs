using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sasanzare
{
    class Program
    {
        static void Main(string[] args)
        {
            int pesos, dollars;
            pesos = Convert.ToInt32(Console.ReadLine());
            dollars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((pesos*2)/100< dollars)?"Pesos":"Dollars");
        }
    }
}
