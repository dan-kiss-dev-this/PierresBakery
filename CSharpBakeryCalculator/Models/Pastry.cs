using System;
using System.Collections.Generic;

namespace CSharpBakeryCalculator.Models
{
    public class Pastry
    {
        public int UnitsOfPastry { get; set; }
        public int FinalPrice { get; set; }

        public int Discount { get; set; }

        private static List<Pastry> _instances = new List<Pastry> { };

        public static List<Pastry> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public Pastry(int numberOfPastry)
        {
            UnitsOfPastry = numberOfPastry;
            CalculateOrderPrice();
            if (numberOfPastry > 0)
            {
                _instances.Add(this);
            }
        }

        public int CalculateOrderPrice()
        {
            int PriceForOne = 2;
            int fullPrice = UnitsOfPastry * PriceForOne;
            // promo buy 3 get 1 free
            int OnePerXFree = 4;
            int freeUnits = Convert.ToInt32(Math.Floor((double)UnitsOfPastry / OnePerXFree));
            Discount = freeUnits * PriceForOne;
            FinalPrice = fullPrice - Discount;
            return FinalPrice;
        }

    }
}