using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode_JaggedArray
{
    class Post
    {
        private static int CurrentPostid = 0;
        //properties
        protected  string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }
        public int ID { get; set; }
        public Post()
        {
            ID = 0;
            Title = "My new post";
            SendByUsername = "Prabhat madan";
            IsPublic = true;
        }
        public Post(string title,bool isPublic,string sendByUserName)
        {
            ID = getNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUserName;
        }
        protected int getNextId()
        {
            return ++CurrentPostid;
        }
        public override string ToString()
        {
            return String.Format("{0}- by -{1}", Title, SendByUsername);
        }

    }
}
