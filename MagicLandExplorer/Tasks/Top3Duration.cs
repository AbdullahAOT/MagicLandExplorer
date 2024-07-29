using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class Top3Duration
    {
        public static void Execute(List<Category> categories)
        {
            var top3Destinations = categories.SelectMany(c => c.Destinations)
                                             .OrderByDescending(d => d.GetDurationInMinutes())
                                             .Take(3)
                                             .Select(d => new { d.Name, d.Duration });

            Console.WriteLine("\nTop 3 longest duration destinations:");
            foreach (var destination in top3Destinations)
            {
                Console.WriteLine($"{destination.Name} ({destination.Duration})");
            }
        }
    }
}
