using Blogger_server.Entities;
using ConsoleApp2.Exceptions;
using ConsoleApp2.Types;
using System.Collections;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic custom array
            FixedList<int> grades = new FixedList<int>(10);
            grades.SetItem(2, 10);
            grades.SetItem(3, 6);
            grades.SwapIndexWithIndex(2, 3);

            Console.WriteLine(grades.GetItem(3));

            grades.SwapValueWithValue(10, 6);

            Console.WriteLine(grades.GetItem(3));
            //EXCEPTIONS
            //Post myStory = new Post() { };

            //try
            //{
            //    Post result = CreatePost(null);
            //} catch(ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    bool registrationResult = RegisterUsername("ionel");
            //} catch(UserUsernameDuplicateException ex)
            //{
            //    Console.WriteLine("this username already exists");
            //} catch(Exception ex)
            //{
            //    Console.WriteLine("something went wrong.");
            //} finally
            //{
            //    Console.WriteLine("Operation completed");
            //}

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