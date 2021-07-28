using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
        int paint;
        int tax;
        int money;
paint= Convert.ToInt32 (Console.ReadLine());
        tax= (40+ paint *5)/100*10;
        money = (40 + paint * 5 + tax);
        {
        Console.WriteLine(Math.Round((paint*5+40)*1.1));   
        }
        }
    }
}
