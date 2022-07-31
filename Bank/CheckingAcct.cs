using System;

namespace RHcodepi
{
    internal class CheckingAcct : Accuonts
    {
        private const decimal OVERDRAW_CHARGE = 35.0m;
        public CheckingAcct(string name, string surname,decimal money) : base(name, surname, money){}

        public void Withdraw(decimal money)
        {
            Balance = (money > Balance) ? (Balance - (money + OVERDRAW_CHARGE)) : Balance - money;
        }

    }
}