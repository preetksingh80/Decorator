using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Components;

namespace CoffeeShop.Decorators
{
    public class CoffeeDecorator:BasicCoffee
    {
        protected readonly BasicCoffee Coffee;

        public CoffeeDecorator(BasicCoffee coffee)
        {
            Coffee = coffee;
        }

        public override string Description
        {
            get {return  Coffee.Description; }
        }
        public override decimal CalculateCost()
        {
            return Coffee.CalculateCost();
        }
    }
}
