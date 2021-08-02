using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;
        
        public Post() {            
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        public string Text {
            get {return text;}
            set {text = value;}
        }
    }
}
