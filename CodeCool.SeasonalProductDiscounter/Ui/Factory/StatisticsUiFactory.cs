using CodeCool.SeasonalProductDiscounter.Service.Products.Statistics;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui.Factory;

public class StatisticsUiFactory : UiFactoryBase
{
    private readonly IProductStatistics _productStatistics;

    public StatisticsUiFactory(IProductStatistics productStatistics)
    {
        _productStatistics = productStatistics;
    }

    public override string UiName => "Statistics";

    public override UiBase Create()
    {
        return new StatisticsUi(_productStatistics, UiName);
    }
}