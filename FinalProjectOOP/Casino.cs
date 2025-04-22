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


            betAmount = Tools.IsValidNumber(player);

            Console.WriteLine($"You have bet {betAmount} chips.  \n");

            Console.WriteLine("You can bet on the individual numbers from 0 to 36 or the color red or black." +
                " \n If you choose the number on the table then you will get 3 times your bet if you choose the correct color it is only 1x.");

            Console.WriteLine("\n What would you like to bet on? (1 for number, 2 for color)");





        }

        public void Slots()
        {

        }

        public void Race()
        {

        }


    }


}
