using System;
using System.Collections.Generic;

namespace rhcodepi.shopinventory
{
    class MainClass
    {
        static Shop shop = new Shop();
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for (int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }
            // shop._Inventory[0] = "milk";
            // shop._Inventory[1] = "eggs";
            // shop._Inventory[2] = "milk";
            try
            {
                // MARK: Result
                Console.WriteLine("Retrieve all stored items:");
                GetAllItems();
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Item doesn't exist or hasn't been assinged. ");
            }
        }

        // MARK: Write your solution here
        public static void AddItem(int index, string name)
        {
            shop._Inventory.Add(index, name);
        }

        // MARK: Write your solution here
        public static void GetAllItems()
        {
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            bool isDup = false;
            foreach (var item in shop._Inventory)
            {
                try
                {
                    dict2.Add(item.Value, item.Key);
                }
                catch (Exception ex) when (ex is ArgumentException)
                {
                    Console.WriteLine("Duplicates cant be added");
                    isDup = true;
                    break;
                }
            }
            if(!isDup) foreach (var item in shop._Inventory) Console.WriteLine(item.Key + "  " + item.Value);
        }
    }
}