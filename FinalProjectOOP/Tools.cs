using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public static class Tools
    {

  

        public static Player CharacterCreator()
        {
            Player player1 = new Player();
            Player savedPlayer = new Player();

            savedPlayer = PullSavedPlayer();
            while (true)
            try
            {
                if (savedPlayer.Name != null)
                {
                    Console.WriteLine("You have a previously used character. Would you like to use your previous character? (y/n)");
                    string response = Console.ReadLine();

                    if (response == "y")
                    {
                        player1 = savedPlayer;
                    }
                    else if (response == "n")
                    {

                        Console.WriteLine("What would you like to name your character?");
                        string playerName = Console.ReadLine();
                        player1.Name = playerName;
                        player1.Chips = 1000;
                    }
                    else
                    {
                        throw new ArgumentException("Unexpected answer, please answer with y or n");

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
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }

        }
        public static Player PullSavedPlayer()
        {
            var savedPlayer = new Player();


            string path = Path.Combine(AppContext.BaseDirectory, @"..\..\..\SaveSheet.json");
            //string path = "C:/Users/jonathan.owen/Source/Repos/FinalProjectOOP/FinalProjectOOP/SaveSheet.json";

            //string n = "C:\Users\Jonathan\source\repos\FinalProjectOOP\FinalProjectOOP\SaveSheet.json"

            var savedInfo = File.ReadAllText(path);
            savedPlayer = JsonSerializer.Deserialize<Player>(savedInfo);
            return savedPlayer;
        }

        public static void SavePlayer(Player player)
        {
            var Player = player;

            string path = Path.Combine(AppContext.BaseDirectory, @"..\..\..\SaveSheet.json");

            //string path = "C:/Users/jonathan.owen/Source/Repos/FinalProjectOOP/FinalProjectOOP/SaveSheet.json";
            string stuffToSave = JsonSerializer.Serialize(Player, new JsonSerializerOptions { WriteIndented = true});
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

        public static int GetValue(string card)
        {
            int value = 0;

            switch (card)
            {
                case "Ace":
                    value = 1;
                    break;
                case "Two":
                    value = 2;
                    break;
                case "Three":
                    value = 3;
                    break;
                case "Four":
                    value = 4;
                    break;
                case "Five":
                    value = 5;
                    break;
                case "Six":
                    value = 6;
                    break;
                case "Seven":
                    value = 7;
                    break;
                case "Eight":
                    value = 8;
                    break;
                case "Nine":
                    value = 9;
                    break;
                default:
                    value = 10;
                    break;
            }

            return value;
        }

        public static int IsValidNumber(string response)
        {
            int amount;

            bool isValid = int.TryParse(response, out amount);

            if (!isValid)
            {
                throw new ArgumentException("Sorry! That cannot be used.");
            }
            return amount;
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
