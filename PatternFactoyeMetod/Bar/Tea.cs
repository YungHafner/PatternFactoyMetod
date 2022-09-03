using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoyMetod.Bar
{
    internal class Tea: IDrinks
    {
        private readonly string _name;
        private readonly decimal _price;

        public Tea(decimal price)
        {
            _name = "Чай сладкий вкусный бодряный";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice()=> _price;
        
    }
}
