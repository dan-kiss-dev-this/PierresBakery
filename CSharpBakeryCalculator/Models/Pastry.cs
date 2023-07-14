using System;

namespace CSharpBakeryCalculator.Models
{
    public class Pastry
    {
        public int UnitsOfPastry { get; set; }
        public int FinalPrice { get; set; }

        public int Discount { get; set; }
        public Pastry(int numberOfPastry)
        {
            UnitsOfPastry = numberOfPastry;
            CalculateOrderPrice();
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