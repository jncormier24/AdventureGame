using System;
using AdventureGame.Models;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Playing = true;
            while (game.Playing)
            {
                Console.WriteLine("Please enter the name of your new Hero: ");
                string Name = Console.ReadLine();

                var hero = new Hero();
                hero.Name = Name;

                Console.Clear();

                Console.WriteLine($"Your name is {hero.Name}");
                Console.WriteLine("What would you like to do: \n"
                                  +"\t 1.) Go into town\n"
                                  +"\t 2.) Go into the forest\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        game.GoToTown("Belmont");
                        break;
                    default:
                        Console.WriteLine("Thank you for playing the game");
                        game.Playing = false;
                        break;
                }
            }
        }
    }
}
