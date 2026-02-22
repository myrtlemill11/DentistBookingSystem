namespace Dentalsystem;

public class Dentist
{
    public string Username;
    public string Password;
    public string Name;

    public Dentist(string username, string password, string name)
    {
        Username = username;
        Password = password;
        Name = name;
    }
}