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
            var login = new Reddit();
            var user = login.LogIn("username", "Password");  // create new Reddit, then create user to login to that reddit. LogIn(username, pass);



            var mysubreddit = login.GetSubreddit("/r/Illisontestbot");

        }


    }
}
