using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08C_Inheritance3
{
    // VideoPost class inherits from the Post class
    class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // inherits the ID, Title, SendByUsername, IsPublic properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        // default constructor
        public VideoPost()
        {
            
        }

        // constructor with 4 parameters
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing video...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            } 
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect(); // garbage collector
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying= false;
                Console.WriteLine("Video stopped at {0} seconds", currDuration);
                // reset duration to zero
                currDuration = 0;
                timer.Dispose();  // stops the timer
            }
        }

        // override the ToString method
        public override string ToString()
        {
            return String.Format("{0} - {1} - video link: {2} - video length: {3} seconds - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
    }
}
