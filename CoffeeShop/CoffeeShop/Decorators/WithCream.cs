using CoffeeShop.Components;

namespace CoffeeShop.Decorators
{
    public class WithCream: CoffeeDecorator
    {
        public WithCream(BasicCoffee coffee) : base(coffee){}

        public override string Description
        {
            get { return Coffee.Description + " With Cream"; }
        }

        public override decimal CalculateCost()
        {
            return Coffee.CalculateCost() + 0.50m;
        }
    }
}