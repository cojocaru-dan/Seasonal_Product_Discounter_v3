﻿using CodeCool.SeasonalProductDiscounter.Service.Products.Browser;
using CodeCool.SeasonalProductDiscounter.Service.Products.Provider;
using CodeCool.SeasonalProductDiscounter.Service.Products.Statistics;

namespace CodeCool.SeasonalProductDiscounterTest;

public class ProductStatisticsTest
{
    private readonly RandomProductGenerator _provider;
    private readonly ProductStatistics _statistics;

    public ProductStatisticsTest()
    {
        _provider = new RandomProductGenerator(50, 10, 70);
        var productBrowser = new ProductBrowser(_provider);
        _statistics = new ProductStatistics(productBrowser);
    }

    [Test]
    public void MostExpensive()
    {
        var expected = _provider.Products.MaxBy(p => p.Price);
        var actual = _statistics.GetMostExpensive();

        Assert.That(actual, Is.EqualTo(expected));
    }
}
