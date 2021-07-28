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
              // Takin' input 
                int fruit;
          fruit = Convert.ToInt32(Console.ReadLine());
    
        // Calculation
         int apples = (fruit / 6);
    
            Console.WriteLine(apples);
    
        }
    }
}
