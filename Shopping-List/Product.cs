using System;

namespace Rhcodepi
{
    internal class Product
    {
        public string? Item {get; set;}
        public float Price {get;set;}
        public int Quantity {get;set;}

        public Product(string item, float price, int quantity)
        {
            Item = item;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Item: {Item,10}, Price : {Price:C}, Quantity : {Quantity}";
        }
        
    }
}