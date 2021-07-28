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
            string youtubeLink = Console.ReadLine();
            if (youtubeLink.Contains("https://www.youtube.com/watch?v=")){
                youtubeLink = youtubeLink.Replace("https://www.youtube.com/watch?v=" , "");
            }
            if (youtubeLink.Contains("https://youtu.be/"))
            {
                youtubeLink = youtubeLink.Replace("https://youtu.be/" , "");
            }
            Console.WriteLine(youtubeLink);
        }
    }
}
