using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Components;

namespace CoffeeShop.Decorators
{
    public class WithChocolate: CoffeeDecorator
    {
       
        public WithChocolate(BasicCoffee coffee) : base(coffee){}

        public override string Description
        {
            get { return Coffee.Description + " With Chocolate"; }
        }

        public override decimal CalculateCost()
        {
            return Coffee.CalculateCost() + .50m;
        }
    }
}
