using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Bank
    {
        //skapar en blank reference av bankmanager 
        //protected string Name { get; set; }
        //protected string Password { get; set; }
        //protected bool IsAdmin { get; set; }
        protected int LoggedInUserIndex { get; set; }

        private Dictionary<int, Bank> UserDictionary = new Dictionary<int, Bank>();
        private Dictionary<int, BankAccount> AccountDictoinary = new Dictionary<int, BankAccount>();

        //startmeny för att logga in / skapa konto
        public void ProgramStart()
        {
            Console.Clear();
            Console.Write("\n\t[1]Logga in" +
                "\n\t[2]Skapa konto" +
                "\n\t[3]Stäng av" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    bankManager.LogIn();
                    break;
                case 2:
                    bankManager.CreateUser();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    bankManager.ProgramStart();
                    break;
            }
        }

        public void EnlistManager(Bank manager) //Frågetecken namn
        {
            //skapar en admin
            Admin admin = new Admin();

            //gör att den tomma referensen som skapades i toppen blir objectet som skapades i "Program"
            bankManager = manager;

            //Lägger till admin i userdictionary
            bankManager.CreatUserAccount(admin);
            bankManager.ProgramStart();
        }

        //simpel check om användaren finns
        public void LogIn()
        {
            Console.Clear();
            Console.Write("\n\tName: ");
            string name = Console.ReadLine();


            Console.Write("\n\tPassword: ");
            string password = Console.ReadLine();

            if (bankManager.DoesUserExist(name, password) == false)
            {
                bankManager.ProgramStart();
            }
        }

        //Methods

        //skapar en användare av "User" och lägger in det i dictionary
        public void CreateUser()
        {
            Console.Clear();
            Console.Write("\n\tName: ");
            string name = Console.ReadLine();

            Console.Write("\n\tPassword: ");
            string password = Console.ReadLine();

            Person newUser = new Person(name, password);
            bankManager.CreatUserAccount(newUser);
            bankManager.ProgramStart();
        }

        public void CreatUserAccount(Bank newUser)
        {
            UserDictionary.Add(UserDictionary.Count, newUser);
            BankAccount newAccount = new BankAccount();
            AccountDictoinary.Add(AccountDictoinary.Count, newAccount);
        }

        //Menyn som visas när man är inloggad
        public void AccountMenu()
        {
            Console.Clear();
            Console.Write("\n\t[1]Add new bank account" +
                "\n\t[2]Show accounts" +
                "\n\t[3]Logout" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    bankManager.AddBankAccount();
                    break;
                case 2:
                    bankManager.DisplayBankAccounts();
                    break;
                case 3:
                    bankManager.ProgramStart();
                    break;
                default:
                    bankManager.AccountMenu();
                    break;
            }
        }

        //Lägger till ett nytt bankkonto
        public void AddBankAccount()
        {
            //kollar så att rätt användare får nytt konto
            foreach (KeyValuePair<int, BankAccount> item in AccountDictoinary)
            {
                if (item.Key == UserIndex)
                {
                    item.Value.AddBankAccount();
                }
            }
            bankManager.AccountMenu();
        }

        //printar ut alla konton användaren har
        public void DisplayBankAccounts()
        {
            //kollar så att rätt användares konton visas
            foreach (KeyValuePair<int, BankAccount> item in AccountDictoinary)
            {
                if (item.Key == UserIndex)
                {
                    item.Value.DisplayBankAccounts();
                }
            }
            Console.ReadLine();
            bankManager.AccountMenu();
        }

        //loop som kollar om namn&lösen stämmer
        public bool DoesUserExist(string name, string password)
        {
            foreach (KeyValuePair<int, Bank> item in UserDictionary)
            {
                if (item.Value.Name == name && item.Value.Password == password)
                {
                    UserIndex = item.Key;
                    bankManager.AccountMenu();
                    return true;
                }
            }
            return false;
        }
    }
}
