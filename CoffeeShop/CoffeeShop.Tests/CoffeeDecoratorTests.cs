using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Components;
using CoffeeShop.Decorators;
using NUnit.Framework;

namespace CoffeeShop.Tests
{
    [TestFixture]
    public class CoffeeDecoratorTests
    {
     
        [Test]
        [TestCase("Basic Coffee")]
        public void BasicCoffeeShouldHaveSayBasicCoffee(string expected)
        {
            var coffee = new BasicCoffee();
            Assert.AreEqual(expected, coffee.Description);

        }


        [Test]
        [TestCase(1.0)]
        public void BasicCoffeeShouldHaveCostOf(decimal expected)
        {
            var coffee = new BasicCoffee();
            Assert.AreEqual(expected, coffee.CalculateCost());

        }

        [Test]
        [TestCase("Basic Coffee With Chocolate")]
        public void BasicCoffeeWithChocolateShouldHaveDescription(string expected)
        {
            var coffee =new  WithChocolate(new BasicCoffee());
           Assert.AreEqual(expected, coffee.Description);

        }

        [Test]
        [TestCase(1.50)]
        public void BasicCoffeeWithChocolateShouldHaveCostOf(decimal expected)
        {
            var coffee = new WithChocolate(new BasicCoffee());
            Assert.AreEqual(expected, coffee.CalculateCost());

        }

        [Test]
        [TestCase("Basic Coffee With Chocolate With Cream")]
        public void BasicCoffeeWithChocolateAndCreamShouldHaveDescription(string expected)
        {
            var coffee = new  WithCream(new WithChocolate(new BasicCoffee()));
            Assert.AreEqual(expected, coffee.Description);

        }

        [Test]
        [TestCase(2.0)]
        public void BasicCoffeeWithChocolateAndCreamShouldHaveCostOf(decimal expected)
        {
            var coffee = new WithCream(new WithChocolate(new BasicCoffee()));
            Assert.AreEqual(expected, coffee.CalculateCost());

        }

        [Test]
        [TestCase("Basic Coffee With Chocolate With Cream With Waffer")]
        public void BasicCoffeeWithChocolateAndCreamAndWafferShouldHaveDescription(string expected)
        {
            var coffee = new WithWaffer(new WithCream(new WithChocolate(new BasicCoffee())));
            Assert.AreEqual(expected, coffee.Description);

        }

        [Test]
        [TestCase(2.50)]
        public void BasicCoffeeWithChocolateAndCreamAndWafferShouldHaveCostOf(decimal expected)
        {
            var coffee = new WithWaffer(new WithCream(new WithChocolate(new BasicCoffee())));
            Assert.AreEqual(expected, coffee.CalculateCost());

        }

        [Test]
        [TestCase("Cappuccino")]
        public void CappuccinoShouldHaveDescription(string expected)
        {
            var coffee = new Cappuccino();
            Assert.AreEqual(expected, coffee.Description);

        }

        [Test]
        [TestCase(2.0)]
        public void CappuccinoShouldHavePrice(decimal expected)
        {
            var coffee = new Cappuccino();
            Assert.AreEqual(expected, coffee.CalculateCost());

        }

        [Test]
        [TestCase("Cappuccino With Chocolate With Cream With Waffer")]
        public void CappuccinoWithChocolateAndCreamAndWafferShouldHaveDescription(string expected)
        {
            var coffee = new WithWaffer(new WithCream(new WithChocolate(new Cappuccino())));
            Assert.AreEqual(expected, coffee.Description);

        }
    }
}
