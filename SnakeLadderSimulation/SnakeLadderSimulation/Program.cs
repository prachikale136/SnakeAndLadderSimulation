namespace SnakeLadderSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Simulation");
            SinglePlayer singleplayer = new SinglePlayer();
            singleplayer.StartPlaying();
            Console.ReadKey();
        }
    }
}