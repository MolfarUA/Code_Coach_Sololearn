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
            String x = Console.ReadLine();
            String[] y = x.Split(' ');
            foreach (var word in y)
            {
                for (int i = 1; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                }
                Console.Write(word[0]);
                 Console.Write("ay ");
            }
        }
    }
}
