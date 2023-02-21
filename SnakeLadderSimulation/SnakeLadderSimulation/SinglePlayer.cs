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
        public int Choice = 0;
        int Option = 0;
        public void StartPlaying()
        {
            Console.WriteLine("Game started");
            while ( StartPoint != 100)
            {
                Random random = new Random();
                RandDice = random.Next(1, 7);  //Random value betw 1 to 6
                Console.WriteLine("Dice Number is : " + RandDice);
                Choice = random.Next(0, 3); //value to check its snake or ladder
                Console.WriteLine("Dice value :" + Choice);
                //Console.WriteLine("you are at " +StartPoint);

                switch (Choice)
                {
                    case 0:  //for no play if choice =0
                        Console.WriteLine("No Play");
                        break;
                    case 1:                         //if choice =1
                        StartPoint += RandDice;  //startPoint = startPoint +randDice
                        if (StartPoint > 100)
                        {
                            StartPoint -= StartPoint; //
                        }
                        Console.WriteLine("Exact Position: " + StartPoint);
                        break;
                    case 2:
                        StartPoint -= RandDice;        //if choice=2
                        if (StartPoint < 0)  //if 0<0 then it will start again
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("snake Attack: " + StartPoint); //startPoint -RandDice
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
