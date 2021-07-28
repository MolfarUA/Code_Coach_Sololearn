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
            string w = Convert.ToString(Console.ReadLine());
            string result = "Unique";
            for (int i = 0; i < w.Length - 1; i++)
            {
                for (int j = 1; j < w.Length - i; j++)
                {
                    if(w[i] == w[j + i])
                {
                    result = "Deja Vu";
                    }
                }
            }
            Console.Write(result);
        }
    }
}
