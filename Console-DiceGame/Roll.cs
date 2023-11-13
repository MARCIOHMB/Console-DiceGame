using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DiceGame
{
    internal class Roll
    {
        const int dieSides = 6;
        string name1;
        string name2;
        int roll;
        int roll1;


        Random random = new Random();



        public static int Math(int m, int p)
        {
            if (m - p >= 8)
                return 3;
            else if (m - p >= 5)
                return 2;
            else return 1;
        }

        public void RollDice()
        {
            int die1 = 0;
            int die2 = 0;
            die1 = random.Next(6) + 1;
            die2 = random.Next(6) + 1;
            roll = die1 + die2;
            roll1 = die1 + die2;
        }

        public void StartUp()
        {
            var continueloop = true;
            var continueloop2 = true;

            do
            {
                try
                {

                    Console.WriteLine("Please input player 1 name");
                    name1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name1))
                        throw new Exception("Error! Name not provided");

                    if (name1.Any(char.IsDigit))
                        throw new Exception("Error! Please use a real name");

                    continueloop = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    // Continue the loop if there's an exception
                }


            } while (continueloop);

            Console.ReadLine();


            do
            {
                try
                {
                    Console.WriteLine("Please input player 2 name");
                    name2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name2))
                        throw new Exception("Error! Name not provided");

                    if (name2.Any(char.IsDigit))
                        throw new Exception("Error! Please use a real name");

                    continueloop2 = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (continueloop2);

            Console.ReadLine();


            Playgame();


        }


        public void Playgame()
        {
            int pie = 0;
            int name1math = 0;
            int name2math = 0;

            int gameCounter = 1;

            while (pie < 6)
            {

                if (gameCounter == 6)
                {
                    Console.WriteLine("Final Game");
                }

                Console.WriteLine("Game " + gameCounter);
                int r1 = (roll + roll1);
                Console.WriteLine(name1 + "  rolled a  " + r1);
                RollDice();

                int r2 = (roll + roll1);
                Console.WriteLine(name2 + "  rolled a  " + r2);
                RollDice();


                if (r1 > r2)
                {
                    name1math += Math(r1, r2);
                    Console.WriteLine(name1 + " won");
                }

                else if (r2 > r1)
                {
                    name2math += Math(r1, r2);
                    Console.WriteLine(name2 + " won");
                }

                else Console.WriteLine("Both players tied");


                Console.WriteLine("Game " + gameCounter + " complete");
                Console.ReadLine();
                pie++;
                gameCounter++;


            }


            Console.WriteLine("Final score:\n" + name1 + ":" + name1math + "\n" + name2 + ":" + name2math);

            Console.ReadLine();

            Console.WriteLine("Thank you for playing!");
        }




    }
}
