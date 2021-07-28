using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Sasanzare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.Replace(Console.ReadLine(), @"[^0-9a-zA-Z ]+", ""));
        }
    }
}
