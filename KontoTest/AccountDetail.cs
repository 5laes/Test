using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class AccountDetails
    {
        public string AccountName { get; set; }
        public decimal Money { get; set; }

        public AccountDetails(string _accountName, decimal _money)
        {
            AccountName = _accountName;
            Money = _money;
        }
    }
}
