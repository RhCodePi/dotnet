using System;

namespace RHcodepi
{
    internal class SavingAcct : Accuonts
    {
        private decimal interestRate;
        private decimal withdrawCharge = 2.0m;
        private int withdrawCount = 0, withdrawLimits = 3;

        public SavingAcct(string name, string surname, decimal interestRate, decimal money)
            : base(name, surname, money){
            this.interestRate = interestRate;
        }

        public void ApplayInterest()
        {
            Balance += (Balance * interestRate);
        }

        public void Withdraw(decimal money)
        {
            if (money > Balance) Console.WriteLine("Attept to overdraw savings - denied");
            else
            {
                if (withdrawCount < withdrawLimits)
                {
                    Balance -= money;
                    withdrawCount++;
                }
                else Balance -= (money + withdrawCharge);
            }
        }

    }
}