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
        public int count;
        public int RandomNumber;
        public string play;

        public int No_play = 0;
        public int Ladder = 1;
        public int Snake = 2;
        public void StartPlaying()
        {
            Console.WriteLine("Game started");
            while ( StartPoint != 100)
            {
                Random random = new Random();
                RandDice = random.Next(1, 7);  //Random value betw 1 to 6
                Console.WriteLine("Dice Number is : " + RandDice);
                RandomNumber = random.Next(0, 3); //value to check its snake or ladder
                //Console.WriteLine("Dice value :" + Choice);
                //Console.WriteLine("you are at " +StartPoint);
                if (RandomNumber == 0)
                {
                    play = "No_play";
                }
                else if (RandomNumber == 1)
                {
                    play = "Ladder";
                }
                else
                {
                    play = "Snake";
                }
                switch (play)
                {
                    case "No_play":  //for no play if choice =0
                        Console.WriteLine("No moves");
                        break;
                    case "Ladder":                         //if choice =1
                        StartPoint += RandDice;  //startPoint = startPoint +randDice
                        count++; 
                        if (StartPoint > 100)  //checking starting point is >100
                        {
                            StartPoint -= RandDice; //startPoit = startPoint - RandDice
                        }
                        Console.WriteLine("Position of player: " + StartPoint);
                        break;
                    case "Snake":
                        StartPoint -= RandDice;        //if choice=2
                        if (StartPoint < 0)  //if 0<0 then it will start again
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("snake Attack: " + StartPoint); //startPoint -RandDice
                        Console.WriteLine("StartPoint");  //if snake attack point will be 0 (initial position 0)
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Dice role to win thw game :" +count);

            }
        }
    }
}
