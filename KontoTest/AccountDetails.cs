using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class AccountDetails
    {
        public string AccountName;
        public decimal Money;
        public AccountDetails(string name, decimal money)
        {
            AccountName = name;
            Money = money;
        }
    }
}
