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
            string MyName=Console.ReadLine();
            int Agents=int.Parse(Console.ReadLine());
            string Names=Console.ReadLine();
         Names+=" "+MyName;
         
         string[] ppl=Names.Split(" ") ;
         Array.Sort<string>(ppl);
         int place=1;
         foreach(string s in ppl)
         {
             if(s==MyName)
             {
                 break;
             }
             place++;
         }
    
        int time=0;
        do
        {
          place-=Agents;  
          time+=20;
        }
        while(place>0);
            
        Console.WriteLine(time);
        }
    }
}
