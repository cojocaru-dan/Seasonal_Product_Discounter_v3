using CodeCool.SeasonalProductDiscounter.Model.Offers;
using CodeCool.SeasonalProductDiscounter.Model.Products;
using CodeCool.SeasonalProductDiscounter.Service.Discounts;
using CodeCool.SeasonalProductDiscounter.Service.Products.Provider;

namespace CodeCool.SeasonalProductDiscounter.Service.Offers;
public class OfferService : IOfferService
{
    private IProductProvider _productProvider = new ProductProvider();
    private IDiscountProvider _discountProvider = new DiscountProvider();
    private IDiscounterService _discounterService => new DiscounterService(_discountProvider);

    public IEnumerable<Offer> GetOffers(DateTime date)
    {
        List<Offer> offers = new();

        foreach (Product product in _productProvider.Products)
        {
            Offer offer = _discounterService.GetOffer(product, date);
            if (offer.Discounts.Any()) offers.Add(offer);
        }
        return offers;
    }
}
