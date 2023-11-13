using System;

namespace Console_DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hello, Welcome to the C# Console Dice Game");
            Console.WriteLine("--------------------------------------------");

            Console.ReadLine();


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Game Overview:");
            Console.WriteLine("The system will ask the user to provide the names for player 1 & player 2. \nIt will then roll the dice for both players and keep track of who rolls the higher number and at the end reveal the score board.");
            Console.WriteLine("The sytem will run the game a total of 6 times.");
            Console.WriteLine("--------------------------------------------");

            Console.ReadLine();

            Console.WriteLine("Let the game begin");

            Console.ReadLine();

            Roll NewGame = new Roll();
            NewGame.StartUp();

            Console.ReadKey();
        }
    }
}