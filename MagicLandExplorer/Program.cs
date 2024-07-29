using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "MagicLandData.json");
            string json = File.ReadAllText(jsonFilePath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            Console.WriteLine("Welcome to Magic Land Explorer!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Show filtered destinations");
                Console.WriteLine("2. Show destination with the longest duration");
                Console.WriteLine("3. Sort destinations by name");
                Console.WriteLine("4. Show top 3 longest duration destinations");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Tasks.FilterDestinations.Execute(categories);
                        break;
                    case "2":
                        Tasks.LongestDuration.Execute(categories);
                        break;
                    case "3":
                        Tasks.SortByName.Execute(categories);
                        break;
                    case "4":
                        Tasks.Top3Duration.Execute(categories);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using Magic Land Explorer. Goodbye!");
        }
    }
}
