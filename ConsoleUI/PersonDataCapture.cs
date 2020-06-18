﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Console.WriteLine("What is your first name: ");

            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");

            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
