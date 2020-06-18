using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last");
                return false;
            }
            return true;
        }
    }
}
