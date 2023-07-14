using System;
using System.Collections.Generic;

namespace CSharpBakeryCalculator.Models
{
    public class Bread
    {
        public int LoafsOfBread { get; set; }
        public int FinalPrice { get; set; }

        public int Discount { get; set; }

        private static List<Bread> _instances = new List<Bread> { };

        public static List<Bread> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public Bread(int units)
        {
            LoafsOfBread = units;
            CalculateOrderPrice();
            if (units > 0)
            {
                _instances.Add(this);
            }
        }

        public int CalculateOrderPrice()
        {
            int PriceForOne = 5;
            int fullPrice = LoafsOfBread * PriceForOne;
            // promo buy 2 get 1 free, so one per 3 free
            int OnePerXFree = 3;
            int freeUnits = Convert.ToInt32(Math.Floor((double)LoafsOfBread / OnePerXFree));
            Discount = freeUnits * PriceForOne;
            FinalPrice = fullPrice - Discount;
            return FinalPrice;
        }
    }
}