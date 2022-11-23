using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoTest
{
    class BankAccount
    {
        private List<AccountDetails> AccountList = new List<AccountDetails>();
        
        public void AddBankAccount()
        {
            Console.Clear();
            BankAccount newAccount = new BankAccount();
            
            Console.Write("\n\tName you account: ");
            string name = Console.ReadLine();

            Console.Write("\n\tMonney to deposit: ");
            decimal.TryParse(Console.ReadLine(), out decimal money);

            AccountDetails test2 = new AccountDetails(name, money);
            AccountList.Add(test2);
        }

        public void DisplayBankAccounts()
        {
            Console.Clear();
            foreach (AccountDetails item in AccountList)
            {
                Console.Write($"\n\t{item.AccountName}: {item.Money}kr");
            }
        }
    }
}
