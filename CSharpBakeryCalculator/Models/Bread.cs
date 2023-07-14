using System;

namespace CSharpBakeryCalculator.Models
{
    public class Bread
    {
        public int FinalPrice { get; set; }

        public int LoafsOfBread { get; set; }
        // add code
        public Bread(int units)
        {
            LoafsOfBread = units;
            CalculateOrderPrice();
        }

        private void CalculateOrderPrice()
        {
            int PriceForOne = 5;
            int fullPrice = LoafsOfBread * PriceForOne;
            // promo buy 2 get 1 free, so one per 3 free
            int OnePerXFree = 3;
            int freeUnits = Convert.ToInt32(Math.Floor((double)LoafsOfBread / OnePerXFree));
            int discount = freeUnits * PriceForOne;
            FinalPrice = fullPrice - discount;
        }
    }
}