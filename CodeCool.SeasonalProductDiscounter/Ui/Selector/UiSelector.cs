using CodeCool.SeasonalProductDiscounter.Ui.Factory;

namespace CodeCool.SeasonalProductDiscounter.Ui.Selector;

public class UiSelector
{
    private readonly SortedList<int, UiFactoryBase> _factories;

    public UiSelector(SortedList<int, UiFactoryBase> factories)
    {
        _factories = factories;
    }

    public UiBase Select()
    {
        Console.WriteLine("Welcome to Seasonal Product Discounter v3");

        DisplayMenu();

        int userInput = GetIntInput();
        UiFactoryBase uiFactory = _factories[userInput];
        UiBase ui = uiFactory.Create();
        return ui;
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Available screens:");
        foreach (var kvp in _factories)
        {
            Console.WriteLine("\t{0} {1}", kvp.Key, kvp.Value.UiName);
        }
    }

    private static int GetIntInput()
    {
        int input = 0;

        while (input == 0)
        {
            Console.WriteLine("Choose an option!");
            var i = Console.ReadLine();
            if (!int.TryParse(i, out input))
            {
                Console.Write("Please provide a valid number!");
            }
            if (input < 1 || input > 3) 
            {
                Console.WriteLine("Please provide a number between 1 and 3");
                input = 0;
            }
        }

        return input;
    }
}
