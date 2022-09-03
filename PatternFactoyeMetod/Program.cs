using PatternFactoyMetod.Bar;
using PatternFactoyMetod.Factories;

class Program
{
    static void Main()
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine(">>> Хаюшки приветушки тут грячительные напитки стыну <<<т \n>>> Попробуйте наши напиточки <<<");

        Console.WriteLine("> Выбери что пить будешь путник");

        Console.WriteLine("> t - Tea");
        Console.WriteLine("> c - Coffee");

        string drinkType = Console.ReadLine();

        IDrinksFactory factory = GetFactory(drinkType);

        IDrinks drinks = factory.GetDrinks();

        Console.WriteLine("\n> Я вас услышал, ваш напиток будет готов с секунды на секунду");

        Console.WriteLine(
            $"\tНазвание\t\t{drinks.Name}\n"+
            $"\tВозьмите на заметку\t{drinks.Description}\n"+
            $"\tЦена - плати или умри\t{drinks.GetPrice()} Rubles\n"
            );
        Console.ReadLine();
    }

#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
    private static IDrinksFactory GetFactory(string drinkType) => drinkType.ToLower() switch
    {
        "t" => new TeaFactory(20, "- Для простачков с легкимм на подъем кошелем"),
        "c" => new CoffeeFactory(200, "- Для обеспеченных в прямом смысле дядь"),
        _ => null
    };
}

