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

        /*
         *UC-03 As a User need to enter a valid email
            - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl& co) and 2 optional (xyz & in) with
                precise @ and . positions
         */
        public static string Emailreg = "^[A-Za-z0-9]{3,}([.][a-zA-z]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

        public static bool ValidateEmail(String word)
        {
            return Regex.IsMatch(word, Emailreg);
        }

        /*
            UC-04-As a User need to
            follow pre- defined Mobile Format 
                -E.g. 91 9919819801 
                - Country code follow by space and 10 digit number
            */
        public static string MobileNoreg = "^(91)[' ']?[7-9]{1}[0-9]{9}$";

        public static bool ValidateMobileNo(String word)
        {
            return Regex.IsMatch(word, MobileNoreg);
        }

    }
}
