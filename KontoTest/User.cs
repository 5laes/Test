using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class User : BankManager
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
            isAdmin = false;
        }
    }
}
