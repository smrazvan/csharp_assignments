using Blogger_server.Entities;
using ConsoleApp2.Exceptions;
using System.Collections;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post myStory = new Post() { };

            try
            {
                Post result = CreatePost(null);
            } catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                bool registrationResult = RegisterUsername("ionel");
            } catch(UserUsernameDuplicateException ex)
            {
                Console.WriteLine("this username already exists");
            } catch(Exception ex)
            {
                Console.WriteLine("something went wrong.");
            } finally
            {
                Console.WriteLine("Operation completed");
            }

        }

        public static bool RegisterUsername(string username)
        {
            if (username.Equals("ionel"))
            {
                throw new UserUsernameDuplicateException("username already exists");
            }
            return true;
        }

        public static Post CreatePost(Post obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException("User object is null");
            }
            return (Post)obj;
            
        }
    }
}