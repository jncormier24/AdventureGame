using System;

namespace AdventureGame.Models
{
    public class Game
    {
        public bool Playing { get; set; }
        
        public void GameOver()
        {
            throw new NotImplementedException();
        }
        
        public void Save() 
        {
            throw new NotImplementedException();
        }
        
        public void GoToTown(string townName)
        {
            Console.WriteLine($"Welcome to {townName}. What would you like to do? \n"
                               + "\t 1.) Shop\n"
                               + "\t 2.) Heal\n"
                               + "\t 3.) Rest\n"
                               + "\t 4.) Save");

            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    goToShop();
                    break;
                case "2":
                    goToHeal();
                    break;
                case "3":
                    goToRest();
                    break;
                case "4":
                    Save();
                    break;
                default:
                    break;
            }
        }

        #region privates

        private void goToShop()
        {
            throw new NotImplementedException();
        }

        private void goToHeal()
        {
            throw new NotImplementedException();
        }

        private void goToRest()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
