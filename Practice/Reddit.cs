using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RedditSharp;
using RedditSharp.Things;

namespace Practice
{
    class RedditApp
    {
        public bool authenticated = false;
        Reddit reddit = null;
        public RedditApp()
        {

            var token = "******";  //Token to login into Reddit's Api

            reddit = new Reddit("*******", "******"); //Bot's login information 

            reddit.InitOrUpdateUser();

            authenticated = reddit.User != null;
            Subreddit sub = null;
            if (!authenticated)
            {
                sub = reddit.GetSubreddit("Illisontestbot");
            }
            var comments = sub.Comments.Take(50); //Last 50 comments. 
            List<RedditCommentModel> model = new List<RedditCommentModel>();  
            foreach (var comment in comments)     
            {
                if (comment.Body.ToLower().Contains("this is a test"))
                {
                    RedditCommentModel newModel = new RedditCommentModel(comment);
                    model.Add(newModel);
                }
            }
            StringBuilder example = new StringBuilder();    // this string example is the reply the bot will post after it finds a comment that contains "this is a test".
            example.Append("This is a test of my bot in my private subreddit.");
            // public class FileStream : System.IO.Stream 
            FileStream fs3 = new FileStream("botexample.txt", FileMode.OpenOrCreate);
            fs3.Close();
            string postCount = File.ReadAllText("botexample.txt");
            int newPostCount = 0;
            if (string.IsNullOrEmpty(postCount))
            {
                newPostCount = 1;
            }
            else
            {
                newPostCount = Convert.ToInt32(postCount);
            }
            example.Replace("X", newPostCount.ToString());


            FileStream fs = new FileStream(" bot - alreadycommented.txt ", FileMode.OpenOrCreate);
            fs.Close();
            string alreadyCommented = File.ReadAllText("bot - alreadycommented.txt ");
            alreadyCommented.Replace("\r\n ", " ");
            string[] commentIds = null;
            if (!string.IsNullOrEmpty(alreadyCommented))
            {
                commentIds = alreadyCommented.Split(',');
            }
            if (commentIds != null && commentIds.Length > 500)
            {
                File.Delete(" bot - alreadycommented.txt ");
            }
            foreach (var comment in model)
            {
                bool commented = false;
                if (commentIds != null)
                {
                    foreach (var id in commentIds)
                    {
                        if (id.TrimEnd('\r', '\n').TrimStart('\r', '\n') == comment.Id)
                        {
                            commented = true;
                        }
                    }
                }
                if (!commented && comment.Id != "\r\n ")
                {
                    try
                    {
                        Comment redditMainComment = (Comment)reddit.GetThingByFullname(comment.Id);
                        example.Replace(newPostCount.ToString(), (newPostCount + 1).ToString());
                        newPostCount = newPostCount + 1;
                        try
                        {
                            redditMainComment.Reply(example.ToString());
                            FileStream fs1 = new FileStream("bot - alreadycommented.txt ", FileMode.OpenOrCreate);
                            fs1.Close();
                            StreamWriter file = File.AppendText("bot - alreadycommented.txt ");
                            file.WriteLine(comment.Id + ",");
                            file.Close();
                        }
                        catch (Exception ex)
                        {
                            newPostCount = newPostCount - 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        //something
                    }
                }
            }
        }
    }
}


