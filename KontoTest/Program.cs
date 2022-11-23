using System;
using System.Collections.Generic;

namespace KontoTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LoadProgram();
            BankAccount acc = new BankAccount();
            BankAccount salary = new BankAccount();
            BankAccount pension = new BankAccount();

            List<BankAccount> AccountList = new List<BankAccount>();
            AccountList.Add(acc);
            AccountList.Add(salary);
            AccountList.Add(pension);
    }

        public static void LoadProgram()
        {
            //Skapar ett object av BankManager och detta objektet
            //sköter all information om alla användare helatiden under programmets gång
            Bank accountManager = new Bank();
            accountManager.EnlistManager(accountManager);
        }
    }
}
