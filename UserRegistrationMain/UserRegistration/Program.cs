using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string NAME_PATTERN = "^[A-Z][a-z]{2,}$";
        static string EMAIL_PATTERN= "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";
        static string MOBILE_PATTERN = "^[0-9]{2} [6-9]{1}[0-9]{9}$";

        Regex regexName = new Regex(NAME_PATTERN);
        Regex regexEmail = new Regex(EMAIL_PATTERN);
        Regex regexMobile = new Regex(MOBILE_PATTERN);


        public void firstNameValidate(string firstName)
        {
            if (regexName.IsMatch(firstName))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
        public void lastNameValidate(string lastName)
        {
            if (regexName.IsMatch(lastName))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }
        public void emailCheck(string emailPattern)
        {
            if (regexEmail.IsMatch(emailPattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }
        public void mobileCheck(string pattern)
        {
            if (regexMobile.IsMatch(pattern))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }
        static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the User registration Program!!!");
                Program pg = new Program();
                Console.WriteLine("Enter Your First Name : ");
                string firstName = Console.ReadLine();
                pg.firstNameValidate(firstName);

                Console.WriteLine("Enter your last name : ");
                string lastName = Console.ReadLine();
                pg.lastNameValidate(lastName);

                Console.WriteLine("Enter your Email id : ");
                string emailID = Console.ReadLine();
                pg.emailCheck(emailID);

                Console.WriteLine("Enter your mobile number : ");
                string mobileNo = Console.ReadLine();
                pg.mobileCheck(mobileNo);
        }
        }
    }