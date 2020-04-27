using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        //Email patterns
        static string EMAIL_PATTERN1 = "^([a-z0-9.-]+)$";
        static string EMAIL_PATTERN2 = "^([a-z0-9.-]+)@([a-z0-9-]+)$";
        static string EMAIL_PATTERN3 = "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})$";
        static string EMAIL_PATTERN4 = "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";
        //Password patterns
        static string PASSWORD_PATTERN1 = "^[a-z]{8,}";
        static string PASSWORD_PATTERN2 = "^[A-Za-z]{8,}";
        static string PASSWORD_PATTERN3 = "^[A-Za-z0-9]{8,}";
        static string PASSWORD_PATTERN4 = "^.*(?=.*[a-z0-9])*(?=.*[A-Z])*(?=.*[!@#$%^&*])(.{8,})$";


        //all patterns name,email,password
        static string NAME_PATTERN = "^[A-Z][a-z]{2,}$";
        static string EMAIL_PATTERN= "^([a-z0-9.-]+)@([a-z0-9-]+).([a-z]{2,8})(.[a-z]{2,8})?$";
        static string MOBILE_PATTERN = "^[0-9]{2} [6-9]{1}[0-9]{9}$";
        static string PASSWORD_PATTERN = "^.*(?=.*[a-z0-9])*(?=.*[A-Z])*(?=.*[!@#$%^&*])(.{8,})$";
  
        Regex regexName = new Regex(NAME_PATTERN);
        Regex regexEmail = new Regex(EMAIL_PATTERN);
        Regex regexMobile = new Regex(MOBILE_PATTERN);
        Regex regexPassword = new Regex(PASSWORD_PATTERN);

        public void firstNameValidate(string firstName)
        {
            if (regexName.IsMatch(firstName))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
        public void lastNameValidate(string lastName)
        {
            if (regexName.IsMatch(lastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
        public void emailValidate(string emailPattern)
        {
            if (regexEmail.IsMatch(emailPattern))
            {
                Console.WriteLine("Valid Email id");
            }
            else
            {
                Console.WriteLine("Invalid Email id");
            }
        }
        public void mobileNoValidate(string pattern)
        {
            if (regexMobile.IsMatch(pattern))
            {
                Console.WriteLine("Valid Mobile number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }
        public void passwordValidate(string pattern)
        {
            if (regexPassword.IsMatch(pattern))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        //Main method
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
                pg.emailValidate(emailID);

                Console.WriteLine("Enter your mobile number : ");
                string mobileNo = Console.ReadLine();
                pg.mobileNoValidate(mobileNo);

                Console.WriteLine("Enter your password : ");
                string password = Console.ReadLine();
                pg.passwordValidate(password);
        }
        }
    }