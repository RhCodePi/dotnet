using System;

namespace RHcodepi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAcct checking = new CheckingAcct("Jhon", "Doe", 2500.0m);
            SavingAcct saving = new SavingAcct("Jane", "Doe", 0.025m, 1000.0m);

            Console.WriteLine($"Checking balance is {checking.Balance :C2}");
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");

            Console.WriteLine($"Checking owner : {checking.AccountOwner}");
            Console.WriteLine($"Saving owner : {saving.AccountOwner}");

            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

            Console.WriteLine($"Checking balance is {checking.Balance :C2}");
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");

            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            Console.WriteLine($"Checking balance is {checking.Balance :C2}");
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");

            saving.ApplayInterest();
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");

            Console.WriteLine($"More than 3 withdrawls - extra charge");
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");

            saving.Withdraw(2000.0m);
            checking.Withdraw(3000.0m);

            Console.WriteLine($"Checking balance is {checking.Balance :C2}");
            Console.WriteLine($"Saving balance is {saving.Balance :C2}");            
        }
    }
}