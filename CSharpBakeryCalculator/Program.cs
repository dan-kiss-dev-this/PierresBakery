using System;
using CSharpBakeryCalculator.Models;

namespace CSharpBakeryCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery");
            Console.WriteLine("We have bread and pastries available");
            Console.WriteLine("Bread is $5 a loaf with a promotion of buy 2 get 1 free for unlimited quantity");
            Console.WriteLine("A Pastry is $2 a loaf with a promotion of buy 3 get 1 free for unlimited quantity");
            Console.WriteLine("How many loafs of bread do you want?");
            int loafsOfBread = Convert.ToInt32(Console.ReadLine());
            Bread orderOfBread = new Bread(loafsOfBread);
            Console.WriteLine("How many pastries do you want?");
            int unitsOfPastry = Convert.ToInt32(Console.ReadLine());
            Pastry orderOfPastry = new Pastry(unitsOfPastry);
            int totalCost = orderOfBread.FinalPrice + orderOfPastry.FinalPrice;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Thanks your total is ${totalCost}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Want to order again? Type 'yes', to exit type 'no' ");
            string makeNewOrder = Console.ReadLine();
            if (makeNewOrder == "yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }

}