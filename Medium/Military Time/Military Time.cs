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
            DateTime d = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(d.ToString("HH:mm"));      // ("hh:mm") 12 hours format, ("HH:mm") 24 hours format
            // or
            // Console.WriteLine(d.ToString("t"));
            // Console.WriteLine(d.ToShortTimeString());
        }
    }
}
