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
try
{
int drinks = Convert.ToInt32(Console.ReadLine());
int shelf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(drinks / shelf);
}
catch (DivideByZeroException)
{
Console.WriteLine("At least 1 shelf");
}
catch (FormatException)
{
Console.WriteLine("Please insert an integer");
}
}
}
}
