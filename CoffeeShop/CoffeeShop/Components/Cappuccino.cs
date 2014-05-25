namespace CoffeeShop.Components
{
    public class Cappuccino : BasicCoffee
    {
        public override string Description
        {
            get { return "Cappuccino"; }
        }
        public override decimal CalculateCost()
        {
            return base.CalculateCost() + 1.0m;
        }
    }
}