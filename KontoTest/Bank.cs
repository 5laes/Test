using System;
using System.Collections.Generic;
using System.Text;

namespace KontoTest
{
    class Bank
    {
        int inloggedUserIndex;

        private Dictionary<int, Person> PersonDictionary = new Dictionary<int, Person>();
        private Dictionary<int, BankAccount> AccountDictoinary = new Dictionary<int, BankAccount>();

        //startmeny för att logga in / skapa konto
        public void ProgramStart()
        {
            Console.Clear();
            Console.Write("\n\t[1]Login" +
                "\n\t[2]Close" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    LogIn();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    ProgramStart();
                    break;
            }
        }

        //skapar en admin
        public void CreateAdmin()
        {
            Admin admin = new Admin();
            PersonDictionary.Add(PersonDictionary.Count, admin);
            BankAccount bankAccount = new BankAccount();
            AccountDictoinary.Add(AccountDictoinary.Count, bankAccount);
        }

        //simpel check om användaren finns
        public void LogIn()
        {
            Console.Clear();
            Console.Write("\n\tName: ");
            string name = Console.ReadLine();
            Console.Write("\n\tPassword: ");
            string password = Console.ReadLine();
            if (DoesUserExist(name, password) == false)
            {
                ProgramStart();
            }
        }

        //skapar en användare av "Person" och lägger in det i dictionary
        public void CreateUser()
        {
            Console.Clear();
            Console.Write("\n\tName: ");
            string name = Console.ReadLine();
            Console.Write("\n\tPassword: ");
            string password = Console.ReadLine();
            Customer newUser = new Customer(name, password);
            PersonDictionary.Add(PersonDictionary.Count, newUser);
            CreatUserAccount();
            AdminMenu();
        }

        //Skapar konto till användaren
        public void CreatUserAccount()
        {            
            BankAccount newAccount = new BankAccount();
            AccountDictoinary.Add(AccountDictoinary.Count, newAccount);
        }

        //Menyn som visas när man är inloggad
        public void CustomerMenu()
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
                    AddBankAccount();
                    break;
                case 2:
                    DisplayBankAccounts();
                    break;
                case 3:
                    ProgramStart();
                    break;
                default:
                    CustomerMenu();
                    break;
            }
        }

        public void AdminMenu()
        {
            Console.Clear();
            Console.Write("\n\t[1]Add new bank account" +
                "\n\t[2]Show accounts" +
                "\n\t[3]Create account" +
                "\n\t[4]Logout" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    AddBankAccount();
                    break;
                case 2:
                    DisplayBankAccounts();
                    break;
                case 3:
                    CreateUser();
                    break;
                case 4:
                    ProgramStart();
                    break;
                default:
                    CustomerMenu();
                    break;
            }
        }

        //Lägger till ett nytt bankkonto
        public void AddBankAccount()
        {
            //kollar så att rätt användare får nytt konto
            foreach (KeyValuePair<int, BankAccount> item in AccountDictoinary)
            {
                if (item.Key == inloggedUserIndex)
                {
                    item.Value.AddBankAccount();
                }
            }
            CustomerMenu();
        }

        //printar ut alla konton användaren har
        public void DisplayBankAccounts()
        {
            //kollar så att rätt användares konton visas
            foreach (KeyValuePair<int, BankAccount> item in AccountDictoinary)
            {
                if (item.Key == inloggedUserIndex)
                {
                    item.Value.DisplayBankAccounts();
                }
            }
            Console.ReadLine();
            CustomerMenu();
        }

        //loop som kollar om namn&lösen stämmer
        public bool DoesUserExist(string name, string password)
        {
            foreach (KeyValuePair<int, Person> item in PersonDictionary)
            {
                if (item.Value.Name == name && item.Value.Password == password)
                {
                    inloggedUserIndex = item.Key;
                    if (item.Value.isAdmin == true)
                    {
                        AdminMenu();
                    }
                    else
                    {
                        CustomerMenu();
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
