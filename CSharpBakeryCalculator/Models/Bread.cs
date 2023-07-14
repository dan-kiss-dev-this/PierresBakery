using System;

namespace CSharpBakeryCalculator.Models
{
    public class Bread
    {
        public int PriceForOne { get; } = 5;

        public int FinalPrice { get; set; }

        public int LoafsOfBread { get; set; }
        public int PriceOfOrder { get; set; }
        // add code
        public Bread(int units)
        {
            LoafsOfBread = units;
            CalculateOrderPrice();
        }

        private void CalculateOrderPrice()
        {
            int fullPrice = LoafsOfBread * PriceForOne;
            // promo buy 2 get 1 free
            int freeUnits = Convert.ToInt32(Math.Floor((double)LoafsOfBread / 3));
            int discount = freeUnits * PriceForOne;
            FinalPrice = fullPrice - discount;
        }
    }
}