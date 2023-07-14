namespace CSharpBakeryCalculator.Models
{
    public class Pastry
    {
        public int UnitsOfPastry { get; set;}
        public Pastry(int numberOfPastry)
        {
            UnitsOfPastry = numberOfPastry;
        }
    }
}