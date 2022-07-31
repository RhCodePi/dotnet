using System;

namespace RHcodepi
{
    internal class Accuonts
    {
        public decimal Balance{get; set;}
        public string? AccountOwner {get; set;}

        public Accuonts(string name, string surname,decimal money){
            Balance = money;
            AccountOwner = name + " " +surname;
        }
        public void Deposit(decimal money)
        {
            Balance += money;
        }
        
    }
}