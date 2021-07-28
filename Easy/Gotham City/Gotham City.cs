using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sasanzare
{
    class Program{
        static void Main(string[] args){
            int input = Convert.ToInt32(Console.ReadLine());
            if(input <5)Console.WriteLine("I got this!");
            else if(input>=5 && input<10)Console.WriteLine("Help me Batman");
            else Console.WriteLine("Good Luck out there!");
        }
    }
}
