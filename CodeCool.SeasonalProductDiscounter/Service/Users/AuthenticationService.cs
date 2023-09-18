using CodeCool.SeasonalProductDiscounter.Model.Users;

namespace CodeCool.SeasonalProductDiscounter.Service.Users;

public class AuthenticationService : IAuthenticationService
{
    private List<User> _usersAccessData = new()
    {
        new User("Emily", "emily22"),
        new User("Benjamin", "benjamin22"),
        new User("Olivia", "olivia22"),
        new User("William", "william22"),
        new User("Ava", "ava22"),
        new User("James", "james22"),
        new User("Sophia", "sophia22"),
        new User("Alexander", "alexander22"),
        new User("Mia", "mia22"),
        new User("Daniel", "daniel22"),
        new User("Charlotte", "charlotte22"),
        new User("Liam", "liam22"),
        new User("Emma", "emma22"),
        new User("Henry", "henry22"),
        new User("Grace", "grace22"),
    };
    public bool Authenticate(User user)
    {
        if (!_usersAccessData.Contains(user)) 
        {
            Console.WriteLine("Your UserName and Password are incorrect!");
            return false;
        }
        return true;
    }
    public List<User> GetUsers() => _usersAccessData;
}