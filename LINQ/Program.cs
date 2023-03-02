using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>
            { "halo","dragon quest","Final Fantasy","NBA2K","FIFA"};

            var gamesOrdered = videoGames.OrderBy(x => x.Length);
            foreach (var x in gamesOrdered)
            {

                Console.WriteLine(x);
            }
        }
    }
}
