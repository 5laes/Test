using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Admin : BankManager
    {
        public Admin()
        {
            Name = "ADMIN";
            Password = "1234";
            isAdmin = true;
        }
    }
}
