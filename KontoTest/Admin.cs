using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Admin : Person
    {
        public Admin()
        {
            Name = "ADMIN";
            Password = "1234";
            isAdmin = true;
        }
    }
}
