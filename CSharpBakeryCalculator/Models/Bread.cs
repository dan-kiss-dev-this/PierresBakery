using System;

namespace CSharpBakeryCalculator.Models
{
    public class Bread
    {
        public int LoafsOfBread { get; set; }
        public int FinalPrice { get; set; }

        public int Discount { get; set; }
      
        public Bread(int units)
        {
            LoafsOfBread = units;
            CalculateOrderPrice();
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