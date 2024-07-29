using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class LongestDuration
    {
        public static void Execute(List<Category> categories)
        {
            var longestDurationDestination = categories.SelectMany(c => c.Destinations)
                                                       .OrderByDescending(d => d.GetDurationInMinutes())
                                                       .FirstOrDefault();

            if (longestDurationDestination != null)
            {
                Console.WriteLine($"\nDestination with the longest duration: {longestDurationDestination.Name} ({longestDurationDestination.Duration})");
            }
            else
            {
                Console.WriteLine("\nNo destinations found.");
            }
        }
    }
}
