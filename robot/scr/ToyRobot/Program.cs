using System;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // parse command line arguments
                // ...

                // configure the application
                // ...

                // create a new board
                Board board = new Board();

                // start the game loop
                while (true)
                {
                    // read user input
                    string input = Console.ReadLine();

                    // process user input and update the board state
                    try
                    {
                        board.ProcessInput(input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while processing input: " + ex.Message);
                    }

                    // check if the game is over
                    if (board.IsGameOver())
                    {
                        // print the final board state
                        board.PrintBoard();

                        // ask user if they want to play again
                        Console.WriteLine("Do you want to play again? (Y/N)");
                        string answer = Console.ReadLine().Trim().ToLower();
                        if (answer == "y")
                        {
                            // reset the board and continue playing
                            board.Reset();
                            continue;
                        }
                        else
                        {
                            // end the game loop
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
