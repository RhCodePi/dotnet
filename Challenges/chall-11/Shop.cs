using System;
using System.Collections.Generic;

namespace rhcodepi.shopinventory
{
    public class Shop
    {
        private Dictionary<int, string> inventory = new Dictionary<int, string>();

        // MARK: Write your solution here

        public Dictionary<int, string> _Inventory{
            get{return inventory;}
            set{
                foreach (var item in value)
                {
                    inventory.Add(item.Key, item.Value);
                }
            }
        }

        public string Indexer(int index)
        {
            return inventory[index];
        }
    }
}