using System;
using System.IO.Compression;

namespace DelegatesSolution
{
    class Program
    {
        public delegate double CalculateShippingDelegate(double price);
        static void Main(string[] args)
        {
            CalculateShippingDelegate calculationFunc;
            do
            {
                Console.WriteLine("What is the destination zone?\n");
                var zone = Console.ReadLine();
                var prompt = zone.ToLower();
                if (prompt != "exit")
                {
                    var destinationCalc = GetShippingCalculation(prompt);

                    if (destinationCalc != null)
                    {
                        calculationFunc = destinationCalc.Calculate;
                        double itemPrice;
                        do
                        {
                            Console.WriteLine("What is the item price?\n");
                            itemPrice = double.TryParse(Console.ReadLine(), out double price) ? price : 0.0;

                            if (price <= 0.0)
                            {
                                Console.WriteLine("price must be a positive number");
                            }

                        } while (itemPrice <= 0.0);

                        Console.WriteLine("The shipping fee is: " + calculationFunc(itemPrice));
                    }

                    continue;
                }

                return;

            } while (true);
        }

        public static ShippingCalculation GetShippingCalculation(string prompt)
        {
            if (prompt.Equals("exit"))
                return null;
            if (prompt.Equals("zone1"))
                return new ShippingCalculationZone1();
            if (prompt.Equals("zone2"))
                return new ShippingCalculationZone2();
            if (prompt.Equals("zone3"))
                return new ShippingCalculationZone3();
            if (prompt.Equals("zone4"))
                return new ShippingCalculationZone4();
            return null;
        }
    }
}
