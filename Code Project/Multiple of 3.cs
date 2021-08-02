using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here           
            for(int i=1; i<=number; i++)
            {                            
            if(i % 3==0)
                {
                     Console.WriteLine("*"); 
                }
                else
                {                  
                    Console.WriteLine(i);
                }
                 
             }                 
        }  
                                     
    }
}
