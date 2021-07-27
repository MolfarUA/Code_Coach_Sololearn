using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void  Main(string[] args)
        {
            int houses;
            houses = Convert.ToInt32(Console.ReadLine());
            
              Console .WriteLine(Math.Ceiling(200.0/houses) );
            
        }
    }
}
