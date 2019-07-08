using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RedditSharp;
using RedditSharp.Things;
namespace Practice
{
    class Login
    {
        //login to reddit using the old way, then the new way QAuth
        public Login()
        {
            var login = new Reddit(); //new Reddit("username", "password");  This <- way shouldn't be done anymore according to redditsharp. As it will be removed soon if not already.
            var user = login.LogIn("username", "Password");  // create new Reddit, then create user to login to that reddit. LogIn(username, pass);
           

            




            var mysubreddit = login.GetSubreddit("/r/Illisontestbot");

        }
        /*public Login()                  Another way to login.
        {
            var login = new Reddit();
            Console.WriteLine("UserName:");
            var user = Console.ReadLine();
            Console.WriteLine("Password:");
            var pass = Console.ReadLine();

            try
            {
                login.LogIn(user, pass);
            }


        }
        */


    }
}
