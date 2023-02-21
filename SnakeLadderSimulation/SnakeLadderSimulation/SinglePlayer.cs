using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulation
{

    internal class SinglePlayer
    {
        public int StartPoint = 0;
        public int RandDice = 0;
        public void StartPlaying()
        {
            Console.WriteLine("Game started");
            Random random = new Random();
            RandDice = random.Next(1, 7);
            Console.WriteLine("Dice Number is : " +RandDice);
            //Console.WriteLine("you are at " +StartPoint);
        }
    }
}
