using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Components
{
    public class BasicCoffee
    {
       public virtual string Description {get { return "Basic Coffee";}}

       public virtual decimal CalculateCost()
       {
           return 1.0m;
       }
    }
}
