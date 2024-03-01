using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08C_Inheritance3
{
    class Post
    {
        private static int currentPostId;

        // Properties
        protected int ID {  get; set; } 
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }   
        protected bool IsPublic { get; set; }

        // Default constructor.  If a derived class does not  invoke a base-class
        // constructor explicitly, the default constructor is called implicitly.

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Bill Stephens";
        }

        // Instance constructor that has 3 parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        // Methods

        // Method to create the ID
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        // Method to edit the post
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic=isPublic;
        }

        // Virtual method override of the ToString() method that is inherited from System.Object.  All objects in C# have a ToString() method,
        // so we can override it to customize for our specific class. (All objects created from classes inherit from System.Object)
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
