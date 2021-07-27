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
            double points, tickets;
             double costGun;
            const double costTicket = 12;
            
            points = Convert.ToDouble(Console.ReadLine());
            costGun = Convert.ToDouble(Console.ReadLine());
            
            tickets = points / costTicket;
            
            if(costGun <= tickets){
                Console.WriteLine ("Buy it!");
            }
            else{
                Console.WriteLine ("Try again");
            }
        }
    }
}
