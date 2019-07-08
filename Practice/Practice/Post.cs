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
            var comments = postReddit.Comments.GetListingStream();

           
        }
    }
}
