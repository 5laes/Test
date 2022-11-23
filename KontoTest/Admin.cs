using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Admin : Bank
    {
        public Admin()
        {
            Name = "ADMIN";
            Password = "1234";
            IsAdmin = true;
        }
        
        

    }
}
