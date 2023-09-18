using CodeCool.SeasonalProductDiscounter.Model.Users;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui;

public class UserAuthenticator
{
    private readonly IAuthenticationService _authenticationService = new AuthenticationService();
    private static string GetTextInput(string text)
    {
        string input = string.Empty;

        while (input == string.Empty)
        {
            Console.Write(text);
            input = Console.ReadLine() ?? string.Empty;
        }

        return input;
    }
    private User GetUser()
    {
        string userName = GetTextInput("Enter Your UserName: ");
        string password = GetTextInput("Enter Your Password: ");
        return new User(userName, password);
    }
    public bool Authenticate()
    {
        var user = GetUser();
        return _authenticationService.Authenticate(user);
    }
}