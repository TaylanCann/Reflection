using System;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            var a = user.GetType();
            Console.WriteLine(a);
            var ab = user.GetType().GetProperties();
            Console.WriteLine(ab[0]);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
