namespace MyBlazorApp.Services
{
public class UserSessionService
{
public string UserName { get; set; }


    public bool IsLoggedIn { get; set; }

    public void Login(string name)
    {
        UserName = name;
        IsLoggedIn = true;
    }

    public void Logout()
    {
        UserName = null;
        IsLoggedIn = false;
    }
}

}
