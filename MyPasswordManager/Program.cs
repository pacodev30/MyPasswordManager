
using MyPasswordManager;

var e = new EntriesManager();
string? choice;

do
{
        Console.WriteLine("\n--- My Password Manager ---");
        Console.WriteLine("1. Add an entry");
        Console.WriteLine("2. List entries");
        Console.WriteLine("3. Delete an entry");
        Console.WriteLine("4. Update the password");
        Console.WriteLine("5. Exit");
        Console.Write("Your choice: ");
        choice = Console.ReadLine();        

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter the name :");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the userName :");
            string? userName = Console.ReadLine();
            Console.WriteLine("Enter the link :");
            string? link = Console.ReadLine();
            Console.WriteLine("Enter the password :");
            string? password = Console.ReadLine();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(link) && !string.IsNullOrEmpty(password))
                e.AddEntry(name, userName, link, password);
            else
                Console.WriteLine("Ow ! enter all data ;)");
            break;

        case "2":
            e.ListEntries();
            break;

        case "3":
            Console.WriteLine("Enter name to delete :");
            string? nameToDelete = Console.ReadLine();
            if(!string.IsNullOrEmpty(nameToDelete))
                e.DeleteEntry(nameToDelete);
            break;

        case "4":
            Console.WriteLine("Name to update :");
            string? nameToUpdate = Console.ReadLine();
            Console.WriteLine("New password :");
            string? newPassword = Console.ReadLine();
            if (!string.IsNullOrEmpty(nameToUpdate) && !string.IsNullOrEmpty(newPassword))
                e.UpdateEntryPassword(nameToUpdate, newPassword);
            else
                Console.WriteLine("Ow ! enter all data ;)");
            break;

        case "5":
            Console.WriteLine("Good Bye");
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

}
while (choice != "5");