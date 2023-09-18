using CodeCool.SeasonalProductDiscounter.Model.Offers;
using CodeCool.SeasonalProductDiscounter.Service.Offers;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui;

public class OffersUi : UiBase
{
    public IOfferService offerService = new OfferService();
    public OffersUi(string title, bool requireAuthentication = false) : base(title, requireAuthentication)
    {}

    public override void Run()
    {
        IEnumerable<Offer> offersToday = offerService.GetOffers(DateTime.Today);
        PrintOffers("All Offers For Today:", offersToday);
    }
    public void PrintOffers(string text, IEnumerable<Offer> offersToday)
    {
        Console.WriteLine(text);
        foreach (Offer offer in offersToday)
        {
            Console.WriteLine($"\t{offer}");
        }
    }
}