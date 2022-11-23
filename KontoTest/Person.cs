using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Person : Bank
    {
        public Person(string name, string password)
        {
            Name = name;
            Password = password;
            IsAdmin = false;
        }
    }
}
