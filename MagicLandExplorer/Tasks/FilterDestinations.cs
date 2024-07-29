using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class FilterDestinations
    {
        public static void Execute(List<Category> categories)
        {
            var filteredDestinations = categories.SelectMany(c => c.Destinations)
                                                 .Where(d => d.GetDurationInMinutes() < 100)
                                                 .Select(d => d.Name);

            Console.WriteLine("\nDestinations with duration less than 100 minutes:");
            foreach (var name in filteredDestinations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
