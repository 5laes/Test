using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoTest
{
    class BankAccount
    {
        string Name;
        decimal Money;

        private List<BankAccount> AccountList = new List<BankAccount>();

        public void AddBankAccount()
        {
            Console.Clear();
            BankAccount newAccount = new BankAccount();
            Console.Write("\n\tName you account: ");
            newAccount.Name = Console.ReadLine();
            Console.Write("\n\tMonney to deposit: ");
            decimal.TryParse(Console.ReadLine(), out decimal money);
            newAccount.Money = money;
            AccountList.Add(newAccount);
        }

        public void DisplayBankAccounts()
        {
            Console.Clear();
            foreach (BankAccount item in AccountList)
            {
                Console.Write($"\n\t{item.Name}: {item.Money}kr");
            }
        }
    }
}
