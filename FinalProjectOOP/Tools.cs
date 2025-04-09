using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public static class Tools
    {

        public static void Game()
        {
            Casino casino = new Casino(GetCasinoName());


        }
        public static Player PullSavedPlayer()
        {
            var savedPlayer = new Player();
            string path = "C:/Users/jonathan.owen/Source/Repos/FinalProjectOOP/FinalProjectOOP/SaveSheet.json";

            var savedInfo = File.ReadAllText(path);
            savedPlayer = JsonSerializer.Deserialize<Player>(savedInfo);
            return savedPlayer;
        }

        public static Player CharacterCreator()
        {
            Player player1 = new Player();
            Player savedPlayer = new Player();

            savedPlayer = Tools.PullSavedPlayer();

            if (savedPlayer.Name != null)
            {
                Console.WriteLine("You have a previously used character. Would you like to use your previous character? (y/n)");
                string response = Console.ReadLine();

                if (response == "y")
                {
                    player1 = savedPlayer;
                }
                else
                {

                    Console.WriteLine("What would you like to name your character?");
                    string playerName = Console.ReadLine();
                    player1.Name = playerName;
                    player1.Chips = 1000;
                }
            }
            else
            {
                Console.WriteLine("What would you like to name your character?");
                string playerName = Console.ReadLine();
                player1.Name = playerName;
                player1.Chips = 1000;
            }

            return player1;
        }

        public static void SavePlayer()
        {
            var Player = new Player();
            string path = "C:/Users/jonathan.owen/Source/Repos/FinalProjectOOP/FinalProjectOOP/SaveSheet.json";
            string stuffToSave = JsonSerializer.Serialize(Player);
            File.WriteAllText(path, stuffToSave);
        }
        public static string GetCasinoName()
        {
            string casinoName = "You shouldn't see this!";
            DaysOfWeek weekday = (DaysOfWeek)DateTime.Now.DayOfWeek;

            switch(weekday)
            {
                case DaysOfWeek.Sunday:
                    casinoName = "God's Casino";
                    break;
                case DaysOfWeek.Monday:
                    casinoName = "Mundane Money Casino";
                    break;
                case DaysOfWeek.Tuesday:
                    casinoName = "Tilted Casino";
                    break;
                case DaysOfWeek.Wednesday:
                    casinoName = "Camel Casino";
                    break;
                case DaysOfWeek.Thursday:
                    casinoName = "Never Hit Casino";
                    break;
                case DaysOfWeek.Friday:
                    casinoName = "Fortune Fumbled Casino";
                    break;
                case DaysOfWeek.Saturday:
                    casinoName = "Golden Hour Casino";
                    break;
            }
            return casinoName;


        }
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
