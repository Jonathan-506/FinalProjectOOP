using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public abstract class Character
    {
        public string Name { get; set; }

        public double Chips { get; set; }


    }

    public class Player : Character
    {
       


        public Player()
        {
           
        }

    }

    public class NPC : Character
    {
       

        public NPC()
        {
            

        }

    }
}
