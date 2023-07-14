using System;
using CSharpBakeryCalculator.Models;

namespace CSharpBakeryCalculator
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"
                _______ _________ _______  _______  _______  _______  _  _______    ______   _______  _        _______  _______          
                (  ____ )\__   __/(  ____ \(  ____ )(  ____ )(  ____ \( )(  ____ \  (  ___ \ (  ___  )| \    /\(  ____ \(  ____ )|\     /|
                | (    )|   ) (   | (    \/| (    )|| (    )|| (    \/|/ | (    \/  | (   ) )| (   ) ||  \  / /| (    \/| (    )|( \   / )
                | (____)|   | |   | (__    | (____)|| (____)|| (__       | (_____   | (__/ / | (___) ||  (_/ / | (__    | (____)| \ (_) / 
                |  _____)   | |   |  __)   |     __)|     __)|  __)      (_____  )  |  __ (  |  ___  ||   _ (  |  __)   |     __)  \   /  
                | (         | |   | (      | (\ (   | (\ (   | (               ) |  | (  \ \ | (   ) ||  ( \ \ | (      | (\ (      ) (   
                | )      ___) (___| (____/\| ) \ \__| ) \ \__| (____/\   /\____) |  | )___) )| )   ( ||  /  \ \| (____/\| ) \ \__   | |   
                |/       \_______/(_______/|/   \__/|/   \__/(_______/   \_______)  |/ \___/ |/     \||_/    \/(_______/|/   \__/   \_/   
            ");
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