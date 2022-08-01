using System;
using System.Collections;
using System.Collections.Generic;
namespace Rhcodepi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fordCount = 0, totalValue = 0;
            List<ClassicCar> carList = new List<ClassicCar>();
            Dictionary<string, int> uniqueCar = new Dictionary<string, int>();
            
            PopulateData(carList);
            ClassicCar valuableCar = carList[0];

            Console.WriteLine($"There are {carList.Count} cars in the entire collection.");
            Console.WriteLine("");
            foreach (var car in carList)
            {
                totalValue += car.m_Value;
                if(car.m_Make == "Ford") fordCount++;
                try
                {
                    uniqueCar.Add(car.m_Make, car.m_Value);
                }
                catch (ArgumentException){}
            }
            Console.WriteLine($"There are {fordCount} Fords in the entire collection.");
            Console.WriteLine("");

            for (int i = 1; i < carList.Count; i++)
            {
                if(valuableCar.m_Value < carList[i].m_Value) valuableCar = carList[i];
            }

            Console.WriteLine($"The most valuable car is a {valuableCar.m_Year} {valuableCar.m_Make} {valuableCar.m_Model} at {valuableCar.m_Value}");
            Console.WriteLine("");

            Console.WriteLine($"The collection is worth {totalValue:C2}");
            Console.WriteLine("");

            Console.WriteLine($"The collection contains {uniqueCar.Count} unique manufacturers.");
            Console.WriteLine("");
        }

        private static void PopulateData(List<ClassicCar> carList)
        {
            carList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            carList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            carList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            carList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            carList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            carList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            carList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            carList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            carList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            carList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            carList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            carList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            carList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            carList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}