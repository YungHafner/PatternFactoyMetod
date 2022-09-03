using PatternFactoyMetod.Bar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoyMetod.Factories
{
    internal class TeaFactory: IDrinksFactory
    {
        private readonly decimal _price;
        private readonly string _description;
        
        public TeaFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IDrinks GetDrinks()
        {
            Tea tea = new(_price)
            {
                Description = _description
            };

            return tea;
        }
    }
}
