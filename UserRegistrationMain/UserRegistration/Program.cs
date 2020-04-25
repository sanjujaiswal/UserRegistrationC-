﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static string NAME_PATTERN = "^[A-Z][a-z]{2,}$";
        Regex regexName = new Regex(NAME_PATTERN);

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
            }
        }
    }