using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    public interface Character
    {
        public string Name { get; set; }

        public int Chips { get; set; }


    }

    public class Player : Character
    {
        public string Name { get; set; }

        public int Chips { get; set; }


        public Player()
        {

        }

    }

    public class NPC : Character
    {
        public string Name { get; set; }

        public int Chips { get; set; }


        public NPC()
        {
            

        }

    }
}
