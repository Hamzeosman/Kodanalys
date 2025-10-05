using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program
    {
        static UserManager userManager = new();

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Lägg till användare!");
                Console.WriteLine("2. Visa användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": userManager.AddUser(); break;
                    case "2": userManager.ShowUsers(); break;
                    case "3": userManager.RemoveUser(); break;
                    case "4": userManager.SearchUser(); break;
                    case "5": isRunning = false; break;
                    default: Console.WriteLine("Ogiltigt val."); break;
                }
                Console.WriteLine();
            }
        }
    }

    class UserManager
    {
        private List<string> users = new();

        public void AddUser()
        {
            Console.Write("Ange namn: ");
            string name = Console.ReadLine();
            users.Add(name);
        }

        public void ShowUsers()
        {
            Console.WriteLine("Användare:");
            users.ForEach(u => Console.WriteLine(u));
        }

        public void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string name = Console.ReadLine();
            if (users.Remove(name))
                Console.WriteLine("Användare borttagen.");
            else
                Console.WriteLine("Användaren hittades inte.");
        }

        public void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string name = Console.ReadLine();
            Console.WriteLine(users.Contains(name)
                ? "Användaren finns i listan."
                : "Användaren hittades inte.");
        }
    }
}

