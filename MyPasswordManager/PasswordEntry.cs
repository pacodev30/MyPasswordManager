
namespace MyPasswordManager
{
    internal class PasswordEntry(string name, string userName, string link, string password)
    {
        private string Name { get; } = name;
        private readonly string UserName = userName;
        private readonly string Link = link;
        private string Password { get; set; } = password;

        public string GetName() => Name;
        public override string ToString()
        {
            return Name + " | " + UserName + " | " + Link + " | " + Password;
        }

        public void SetPassword(string password)
        {
            Password = password;
            Console.WriteLine($"-> Password {Name} is modified with succes :)");
        }

    }
}
