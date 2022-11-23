﻿using System;

namespace KontoTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LoadProgram();
        }

        public static void LoadProgram()
        {
            //Skapar ett object av BankManager och detta objektet
            //sköter all information om alla användare helatiden under programmets gång
            Bank accountManager = new Bank();
            accountManager.CreateAdmin();
            accountManager.ProgramStart();
        }
    }
}
