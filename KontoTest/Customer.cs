using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Customer : Person
    {
        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            isAdmin = false;
        }
    }
}
