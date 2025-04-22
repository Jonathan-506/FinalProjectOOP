using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public class Casino
    {
        public string Name { get;  set; }
        public bool OpenOrClosed { get; set; }
        public Casino(string name) 
        {
            Name = name;
        }

        public void BlackJack()
        {
            
            
            
        }

        public void Roulette(Player player)
        {
            
            int betAmount;
           

            Console.WriteLine($" Welcome to the Table {player.Name}!\n How much would you like to bet? You currently have {player.Chips} chips.");
            string response = Console.ReadLine();

            betAmount = Tools.IsValidNumber(response);

            Console.WriteLine($"You have bet {betAmount} chips.\n");
            player.Chips -= betAmount;

            Console.WriteLine("You can bet on the individual numbers from 0 to 36 or the color red or black." +
                " \n If you choose the number on the table then you will get 5 times your bet if you choose the correct color it is only 2 times.");

            Console.WriteLine("\n What would you like to bet on? (1 for number, 2 for color)");
            response = Console.ReadLine();


            WheelFortune(response, betAmount, player);

            Console.WriteLine("\nWould you like to play again? (y/n)");
            response = Console.ReadLine();

            if(response == "y")
            {
                Roulette(player);
            }

        }

        public void Slots()
        {

        }

        public void Race()
        {

        }


        internal void WheelFortune(string response, int betAmount,  Player player)
        {
            Random rnd = new Random();

            switch (Tools.IsValidNumber(response))
            {
                case 1:
                    Console.WriteLine("Please choose a number between 0 and 36!");
                    response = Console.ReadLine();

                    Console.WriteLine("The Wheel is being spun!");
                    int wheelnumber = rnd.Next(0, 37);
                    Console.WriteLine("The Wheel has finished spinning");

                    Console.WriteLine($"The Wheel landed on {wheelnumber}");

                    if (Tools.IsValidNumber(response) == wheelnumber)
                    {
                        Console.WriteLine("You Win!");
                        player.Chips += betAmount * 5;
                    }
                    else
                    {
                        Console.WriteLine("Aw better luck next time");
                    }
                    break;
                case 2:
                    Console.WriteLine("Please choose a color between black and red (b for black and r for red)");
                    response = Console.ReadLine();

                    Console.WriteLine("The Wheel is being spun!");
                     wheelnumber = rnd.Next(0, 37);
                    Console.WriteLine("The Wheel has finished spinning");

                    if (response == "b" && wheelnumber % 2 == 0)
                    {
                        Console.WriteLine("You Win!");
                        player.Chips += betAmount * 5;
                    }
                    else if (response == "r" && wheelnumber % 2 != 1)
                    {
                        Console.WriteLine("You Win!");
                        player.Chips += betAmount * 5;
                    }
                    else
                    {
                        Console.WriteLine("Aw better luck next time");

                    }
                    break;
                default:
                    Console.WriteLine("you should not see this");
                    break;
            }

        }


    }


}
