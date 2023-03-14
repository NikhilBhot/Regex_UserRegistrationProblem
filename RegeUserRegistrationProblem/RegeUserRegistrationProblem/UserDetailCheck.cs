using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegeUserRegistrationProblem
{
    internal class UserDetailCheck
    {
        /*
               UC-01As a User need to enter a valid First Name
                   - First name starts with Cap and has minimum 3 characters
           */
        public static string FirstNamereg = "^[A-Z][A-za-z]{2,}";

        public static bool ValidateFirstName(String word)
        {
            return Regex.IsMatch(word, FirstNamereg);
        }
        /*
                UC-02As a User need to enter a valid Last Name
                    - Last name starts with Cap and has minimum 3 characters
            */
        public static string LastNamereg = "^[A-Z][A-za-z]{2,}";
        public static bool ValidateLastName(String word)
        {
            return Regex.IsMatch(word, LastNamereg);
        }
    }
}
