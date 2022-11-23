using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoTest
{
    class BankAccount
    {

        private List<AccountDetails> BankAccountList = new List<AccountDetails>();

        public void AddBankAccount()
        {
            Console.Clear();
            Console.Write("\n\tName you account: ");
            string name = Console.ReadLine();
            Console.Write("\n\tMonney to deposit: ");
            decimal.TryParse(Console.ReadLine(), out decimal money);
            AccountDetails newAccount = new AccountDetails(name, money);
            BankAccountList.Add(newAccount);
        }

        public void DisplayBankAccounts()
        {
            Console.Clear();
            foreach (AccountDetails item in BankAccountList)
            {
                Console.Write($"\n\t{item.Name}: {item.Money}kr");
            }
        }
    }
}
