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
            casino.OpenOrClosed = true;

            Console.WriteLine("Welcome To High Card");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);


            var player = Tools.CharacterCreator();

            while (casino.OpenOrClosed || player.Chips > 0)
            {
                Console.WriteLine($"Welcome to {casino.Name}! \n");


                Console.Clear();
                GameMenu(player, casino);
            }
            if(player.Chips <= 0)
            {
                Console.WriteLine("You lost all your chips and never hit it big! \n Your story fades into oblivion.");
                player.Name = null;
                Tools.SavePlayer(player);
            }

            Console.WriteLine(" The Casino has closed for the day. \n Thanks for playing!  Have a Lucky day!");
        }


        public static void GameMenu(Player player, Casino casino)
        {
            
            Console.WriteLine("What would you like to do?");
            Console.WriteLine(" 1. Save \n 2. Save and Quit \n 3. Roulette Table \n 4. Horse Race \n 5. BlackJack \n 6. Player Information");
            int playerResponse = int.Parse(Console.ReadLine());
            switch (playerResponse)
            {
                case (int)MenuNav.Save:
                    Tools.SavePlayer(player);
                    Console.WriteLine("Game saved!");
                    Console.ReadKey(true);
                    break;
                case (int)MenuNav.Quit:
                    Tools.SavePlayer(player);
                    casino.OpenOrClosed = false;
                    break;
                case (int)MenuNav.RouletteTable:
                    casino.Roulette(player);
                    break;
                case (int)MenuNav.Race:
                     casino.Race(player);

                    break;
                case (int)MenuNav.BlackJack:
                    casino.BlackJack(player);
                    break;
                case (int)MenuNav.PlayerInfo:
                    Console.WriteLine($"Name: {player.Name} \nChips: {player.Chips}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
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
        PlayerInfo
    }
}
