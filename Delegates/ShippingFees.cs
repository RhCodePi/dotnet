using System;

namespace Rhcodepi
{
    internal class ShippingFess
    {
        private float fees;
        private float tax;
        private float netPrice;
        public bool zoneExist {get; set;}

        public string CalculateZoneFees(string zone,float price)
        {
            if(zone == "zone1")
            {
                fees = 0.25f;
                netPrice = price*fees;
            }
            else if(zone == "zone2")
            {
                fees = 0.12f;
                tax = 25f;
                netPrice = (price*fees) + tax;
            }
            else if(zone == "zone3")
            {
                fees = 0.08f;
                netPrice = price * fees;
            }
            else if(zone == "zone4")
            {
                fees = 0.04f;
                tax = 25f;
                netPrice = (price*fees) + tax;
            }
            else{
                zoneExist = false;
                return null;
            }
            return $"{netPrice:C2}";
        }
    }
}