using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(  );
            game.Playing = true;
            while (game.Playing)
            {
                Console.WriteLine("Please enter the name of your new Hero: ");
                string Name = Console.ReadLine();

                Hero Hero = new Hero();
                Hero.Name = Name;
            }
        }
    }

    class Game {
        public bool Playing
        {
            get; set;
        }
        public void GameOver() {
            
        }
        public void Save() { }
    }
    class Character {
        public string Name
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public int Health
        {
            get; set;
        }
    }
    class Hero : Character {

    }
    class Enemy : Character {

    }
    class Item {
        public string Name
        {
            get; set;
        }
    }
    class Weapon : Item {
        public int Damage {
            get; set;
        }
        public int Durability
        {
            get; set;
        }
    }
}
