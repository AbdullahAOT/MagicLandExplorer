using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class SortByName
    {
        public static void Execute(List<Category> categories)
        {
            var sortedDestinations = categories.SelectMany(c => c.Destinations)
                                               .OrderBy(d => d.Name)
                                               .Select(d => d.Name);

            Console.WriteLine("\nDestinations sorted by name:");
            foreach (var name in sortedDestinations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
