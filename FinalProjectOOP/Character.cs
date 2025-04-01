using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    class Character
    {
        public string Name { get; set; }

        public int Chips { get; set; }

        public Character()
        {

        }
    }

    class Player : Character
    {
        public Player()
        {

        }


    }

    class NPC : Character
    {

    }
}
