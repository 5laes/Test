using System;

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
            Bank accountManager = new Bank();
            accountManager.CreateAdmin();
            accountManager.ProgramStart();
        }
    }
}
