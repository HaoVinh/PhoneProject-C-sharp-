using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class RegexPattern
    {
        //private Regex emailRegex = new Regex("(?<user>[^@]+)@(?<host>.+)");
        private Regex validatePhoneNumberRegex = new Regex("^0[0-9]{9,10}$");

        //public bool checkEmail(string Email)
        //{
        //    return emailRegex.IsMatch(Email);
        //}

        public bool checkPhoneNumber(string PhoneNumber)
        {
            return validatePhoneNumberRegex.IsMatch(PhoneNumber);
        }

    }
}
