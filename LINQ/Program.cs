using Console = System.Console;


using System;
using System.Collections.Generic;
using System.Linq;  
namespace LINQ_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Legend of Zelda",
                "Throne and Liberty",
                "Runescape",
                "Final Fantasy",
                "Centipede",
                "Pac-Man"
            };
// order by length of game names
            var orderedGames = videoGames.OrderBy(game => game.Length).ToList();
            //print sorted list to console
            Console.WriteLine("Video games ordered by length of name: ");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
