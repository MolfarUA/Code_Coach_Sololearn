using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{

    class Program
    { 
    static string[] numWords =  {"zero","one","two","three",    "four","five","six","seven","eight","nine"," ten"};
     static string numbers = "012345678910";
    
        static void Main(string[] args)
        {
          string input = Console.ReadLine();
        string[] inPut = input.Split(" ");
    string[] output = new string[inPut.Length];
    int num = 0;
          for(int i =0;i<inPut.Length;i++)
 {
 
    if(numbers.Contains(inPut[i])) 
    {num = Convert.ToInt32(inPut[i]);
     output[i] = numWords[num];
    } 
    else output[i] = inPut[i];       
 }
 String outPut = String.Join(" ",output);
 Console.WriteLine(outPut);
        }
    }
}
