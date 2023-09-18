using CodeCool.SeasonalProductDiscounter.Service.Products.Statistics;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui;

public class StatisticsUi : UiBase
{
    private readonly IProductStatistics _productStatistics;

    public StatisticsUi(IProductStatistics productStatistics, string title, bool requireAuthentication = true) : base(title, requireAuthentication)
    {
        _productStatistics = productStatistics;
    }

    public override void Run()
    {
        Console.WriteLine($"Total products: {_productStatistics.TotalProducts()}");
        Console.WriteLine($"Average price of products: {_productStatistics.GetAveragePrice()}");
        Console.WriteLine($"Cheapest product: [{_productStatistics.GetCheapest()}]");
        Console.WriteLine($"Most expensive product [{_productStatistics.GetMostExpensive()}]");
    }
}
