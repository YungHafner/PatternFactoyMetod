using PatternFactoyMetod.Bar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoyMetod.Factories
{
    internal class CoffeeFactory:IDrinksFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public CoffeeFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IDrinks GetDrinks()
        {
            Coffee coffee = new(_price)
            {
                Description = _description
            };

            return coffee;
        }
    }
}
