using System.Collections.Generic;

namespace MyPasswordManager
{
    internal class EntriesManager
    {
        private List<PasswordEntry> Entries { get; set; } = [];

        public void ListEntries()
        {
            if(Entries.Count == 0)
            {
                Console.WriteLine("-> No entries found !");
                return;
            }
            Console.WriteLine("-- Passwords list --");
            foreach (var entry in Entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void AddEntry(string name, string username, string link, string password) 
        {
            Entries.Add(new PasswordEntry(name, username, link, password));
            Console.WriteLine($"-> {name} add with succes :)");
        }


        public void DeleteEntry(string name)
        {
            var entryToRemove = Entries.Find(e => e.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
            if (entryToRemove != null)
            {
                Entries.Remove(entryToRemove);
                Console.WriteLine($"-> {entryToRemove.GetName()} is removed :o");
            }
            else
            {
                Console.WriteLine($"-> {name} is not found :(");
            }
        }

        public void UpdateEntryPassword(string nameToUpdate, string newPassword)
        {
            var entryToDelete = Entries.Find(e => e.GetName().Equals(nameToUpdate, StringComparison.OrdinalIgnoreCase));
            if (entryToDelete != null)
            {
                entryToDelete.SetPassword(newPassword);
                Console.WriteLine($"-> Password of {entryToDelete.GetName()} is updated :)");
            }
            else
            {
                Console.WriteLine($"-> {nameToUpdate} is not found :(");
            }
        }
    }
}
