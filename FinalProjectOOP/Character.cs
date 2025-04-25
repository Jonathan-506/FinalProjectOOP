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

        public List<Card> Hand { get; set; }


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



    public class Racer
        {
            public string Name { get; set; }
            public int ProgressCounter { get; set; }
            public int Position { get; set; }
            private int RaceTrack { get; set; } = 25;
            public Racer()
            {

            }


            internal void Move()
            {

                Random rnd = new Random();

            

                while (ProgressCounter < RaceTrack)
                {
                    ProgressCounter += rnd.Next(1, 6);
                    Thread.Sleep(rnd.Next(500, 1001));

                }
                lock (this)
                {
                
                    Racing.FinishLine(Name, Position);

                }

            }
        }

   
}
