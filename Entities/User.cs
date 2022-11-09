using Blogger_server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class User
    {
        public string FullName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string About { get; set; } = string.Empty;

        public virtual void PresentFunction()
        {
            Console.WriteLine("I am a simple user");
        }
        
        //overloading constructor
        public User() { }

        public User(string username)
        {
            Username = username;
        }

        public User(string fullName, string username, string about)
        {
            FullName = fullName;
            Username = username;
            About = about;
        }
    }
}
