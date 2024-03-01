using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08C_Inheritance3
{
    // ImagePost class inherits from the Post class
    class ImagePost : Post
    {
        // inherits the ID, Title, SendByUsername, IsPublic properties

        public string ImageURL { get; set; }

        public ImagePost()
        {
            
        }

        public ImagePost(string title, string sendByUsername, bool isPublic, string imageURL)
        {
            this.ID = GetNextID(); // note that GetNextID is automatically inherited from Post class (the method is protected so can be inherited)
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }

        public override string ToString() {
            return String.Format("{0} - {1} - image link: {2} - by {3}, ", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
