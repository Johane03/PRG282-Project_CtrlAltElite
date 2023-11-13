using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test.BusinessLogicLayer
{
    internal class Logic
    {
        //Validate password when registering
        public Boolean ValidatePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).*$");

        }
    }
}
