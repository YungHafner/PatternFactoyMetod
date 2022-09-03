using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoyMetod.Bar
{
    internal interface IDrinks
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
