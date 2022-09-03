using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoyMetod.Bar
{
    class Coffee : IDrinks
    {
        private readonly string _name;
        private readonly decimal _price;

        public Coffee(decimal price)
        {
            _name = "Кофеёк с молочком";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
