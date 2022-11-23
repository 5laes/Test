using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class AccountDetails
    {
        public string Name;
        public decimal Money;
        public AccountDetails(string name, decimal money)
        {
            Name = name;
            Money = money;
        }
    }
}
