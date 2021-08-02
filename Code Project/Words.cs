using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =  {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int num = 0;

           
            for( int count = 0; count < 10; count++){
                if(words[count].Contains(letter)){
                Console.WriteLine(words[count]);
                
                num++;
                }
    
        }
           if(num == 0){
               Console.WriteLine("No match");
           }

            

        }
    }
}
