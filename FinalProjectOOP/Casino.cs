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

    public class Racing
    {
        public static int RaceOver { get; set; } = 0;
        public static void StartRace()
        {
            Console.WriteLine("Racers Start your Engines!");

            Racer horse1 = new Racer();
            Racer horse2 = new Racer();
            Racer horse3 = new Racer();
            horse1.Name = "Brown";
            horse2.Name = "Mustang";
            horse3.Name = "Pontiac";

            Console.WriteLine("Ready.... Set........ GOOOOO!");

            Thread t1 = new Thread(horse1.Move);
            Thread t2 = new Thread(horse2.Move);
            Thread t3 = new Thread(horse3.Move);

            t1.Start();
            t2.Start();
            t3.Start();
        }

        public static void FinishLine(string name)
        {
            if (RaceOver == 0)
            {
                Console.Clear();
                RaceOver++;
                Console.WriteLine(name + " has taken First place!");

            }
            else if (RaceOver == 1)
            {
                RaceOver++;
                Console.WriteLine(name + " has taken Second place!");
            }
            else if (RaceOver == 2)
            {
                Console.WriteLine(name + " has taken Third place!");
            }
        }
    }
}
