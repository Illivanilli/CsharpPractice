using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RedditSharp;
using RedditSharp.Things;


namespace Practice
{
    class RedditCommentModel 
    {
        ObservableCollection<RedditCommentModel> commentTracked;
        private Comment comment;

        public string commentString { get; set; }
         public string id { get; set; }
        public string Id { get; internal set; }

        public RedditCommentModel(string commentString)
        {
            this.commentString = commentString;

        }
        public RedditCommentModel()
        {

        }

        public RedditCommentModel(Comment comment)
        {
            this.comment = comment;
        }
    }
}
