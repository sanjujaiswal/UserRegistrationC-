using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string NAME_PATTERN = "^[A-Z][a-z]{2,}$";
        Regex regexName = new Regex(NAME_PATTERN);

        public void patternCheck(string pattern)
        {
            if (regexName.IsMatch(pattern))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }

        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User registration Program!!!");
            Program pg = new Program();
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            pg.patternCheck(firstName);
        }
    }
}