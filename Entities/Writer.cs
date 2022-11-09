using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Writer : User, IEnumerable<string>, ICloneable
    {
        private List<string> posts = new List<string>();

        public void AddPost(string name)
        {
            posts.Add(name);
        }

        public override void PresentFunction()
        {
            Console.WriteLine("I am a writer");
        }

        //implement IClonable
        public object Clone()
        {
            return (Writer)this.MemberwiseClone();
        }

        //implement IEnumerable
        public IEnumerator<string> GetEnumerator()
        {
            return posts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return posts.GetEnumerator();
        }

        public Writer() : base() { }

        public Writer(string username) : base(username) { }

        public Writer(string fullName, string username, string about) : base(fullName, username, about) { }
    }
}
