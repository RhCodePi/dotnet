using System;

namespace Rhcodepi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            GenerateList(products);

            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }

        }

        static void GenerateList(List<Product> product)
        {
            product.Add(new Product("Apple", 0.95f, 6));
            product.Add(new Product("Milk", 2.25f, 1));
            product.Add(new Product("Sugar", 1.75f, 2));
            product.Add(new Product("Bread", 3.25f, 1));
            product.Add(new Product("Butter", 4.95f, 1));
            product.Add(new Product("Cookies", 0.50f, 4));
            product.Add(new Product("Oranges", 0.65f, 5));
            product.Add(new Product("Chicken", 8.95f, 1));
        }
    }
}