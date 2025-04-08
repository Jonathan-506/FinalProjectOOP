using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public static class Gamble
    {

        public static void StartGame()
        {
            Console.WriteLine("Welcome To High Card");
            Console.WriteLine("");


        }
        public static void CharacterCreator()
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
                    casinoName = "God's GoodLuck Casino";
                    break;
                case DaysOfWeek.Monday:
                    casinoName = "PlaceHolderText";
                    break;
                case DaysOfWeek.Tuesday:
                    casinoName = "PlaceHolderText";
                    break;
                case DaysOfWeek.Wednesday:
                    casinoName = "PlaceHolderText";
                    break;
                case DaysOfWeek.Thursday:
                    casinoName = "PlaceHolderText";
                    break;
                case DaysOfWeek.Friday:
                    casinoName = "PlaceHolderText";
                    break;
                case DaysOfWeek.Saturday:
                    casinoName = "PlaceHolderText";
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
