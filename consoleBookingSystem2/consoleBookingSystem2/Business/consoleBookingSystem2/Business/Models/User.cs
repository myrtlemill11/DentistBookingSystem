namespace consoleBookingSystem2.Business.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public User(int id, string username, string password, string name)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {Id})";
        }
    }
}
