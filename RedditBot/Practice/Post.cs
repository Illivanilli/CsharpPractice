using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RedditSharp;
using RedditSharp.Things;

namespace Practice
{
    class Post
    {
        Reddit postReddit = new Reddit();
        public Post()
        {
            Comment newComment = new Comment();

            var mysubreddit = newComment.GetSubreddit("/r/Illisontestbot");


        }
    }
}
