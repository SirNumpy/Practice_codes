using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeCode_JaggedArray
{
    class VideoPost:Post
    {
        //fields
        Timer timer;
       protected bool isPlaying = false;
        protected int counter = 0;
        public string VideoUrl { get; set; }
        public int Length { get; set; }
        public VideoPost()
        {
           
        }
        public VideoPost(string videoUrl,int length)
        {
            this.ID = getNextId();
            this.VideoUrl = videoUrl;
            this.Length = length;
            this.IsPublic = true;
            this.SendByUsername = "prabhat";

        }
        public void play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                timer = new Timer(callback, null, 0, 1000);
            }

        }
        private void callback(object o)
        {
            if (counter < Length)
            {
                Console.WriteLine("video is {0} sec elapsed",counter++);
                GC.Collect();
            }
            else
            {
                stop();
            }
        }
        public void stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("video is stopped at {0} sec",counter);
                counter = 0;
                timer.Dispose();
                Console.ReadKey();
            }
        }

    }
}
