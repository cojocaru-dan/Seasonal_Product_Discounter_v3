using CodeCool.SeasonalProductDiscounter.Model.Products;
using CodeCool.SeasonalProductDiscounter.Service.Products.Browser;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui;

public class ProductsUi : UiBase
{
    private readonly IProductBrowser _productBrowser;

    public ProductsUi(IProductBrowser productBrowser, string title, bool requireAuthentication = true) : base(title, requireAuthentication)
    {
        _productBrowser = productBrowser;
    }

    public override void Run()
    {
        PrintProducts("All products:", _productBrowser.GetAll());
    }

    private static void PrintProducts(string text, IEnumerable<Product> products)
    {
        Console.WriteLine(text);
        foreach (var product in products)
        {
            Console.WriteLine($"\t{product}");
        }
    }
}
