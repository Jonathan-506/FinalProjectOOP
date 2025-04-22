using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    class GameParts
    {
        public static void Game()
        {
            Casino casino = new Casino(Tools.GetCasinoName());
            bool gameSignal = true;

            Console.WriteLine("Welcome To High Card");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);


            var player = Tools.CharacterCreator();

            while (gameSignal)
            {
                Console.WriteLine($"Welcome to {casino.Name}");

                Console.Clear();
                GameMenu(player, gameSignal, casino);
            }

            Console.WriteLine("Thanks for playing! \n Have a Lucky day!");

        }


        public static void GameMenu(Player player, bool gameSignal, Casino casino)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine(" 1. Save \n 2. Save and Quit \n 3. Roulette Table \n 4. Horse Race \n 5. BlackJack");
            int playerResponse = int.Parse(Console.ReadLine());
            switch (playerResponse)
            {
                case (int)MenuNav.Save:
                    Tools.SavePlayer(player);
                    break;
                case (int)MenuNav.Quit:
                    Tools.SavePlayer(player);
                    gameSignal = false;
                    break;
                case (int)MenuNav.RouletteTable:
                    casino.Roulette(player);
                    break;
                case (int)MenuNav.Race:
                    break;
                case (int)MenuNav.BlackJack:
                    break;
                default:
                    break;



            }
        }
    }
    public enum MenuNav
    {
        none,
        Save, 
        Quit,
        RouletteTable,
        Race,
        BlackJack,
    }
}
