using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string p2="X" , p1 = "O";
            //loop for game
            String playAgain = "yes";
            while(playAgain.Equals("yes"))
            {
                String[,] Board =
           {
            {"*","*","*"}, //row 0
            {"*","*","*"}, //row 1
            {"*","*","*"}, //row 2
            };
                int counter = 1;
                Boolean endGame = false;
                while (endGame == false)
                {
                    
                    displayBoard(Board,counter);
                    playerOne(ref Board, p1);
                   Console.Clear();
                    endGame = CheckForWin(Board,endGame, counter);
                    if(endGame == true){
                        break;
                    }
                    displayBoard(Board, counter);
                    playerTwo(ref Board, p2);
                   Console.Clear();
                    endGame = CheckForWin(Board,endGame, counter);
                    counter = counter + 1;
                    
                }


                Console.WriteLine("Wanna play again? yes/no");
                playAgain = Console.ReadLine();
                while (!(playAgain.ToLower() == "yes" || playAgain.ToLower() == "no"))
                {
                    Console.WriteLine(playAgain);
                    Console.WriteLine("please enter yes or no.");
                    playAgain = Console.ReadLine();
                }

            }
            Console.ReadLine();
        }

        static void displayBoard (String[,] Board, int counter)
        {
            Console.WriteLine("Player 1: O");
            Console.WriteLine("Player 2: X");
            Console.WriteLine(" ");
            Console.WriteLine("Round: "+ counter);
            Console.WriteLine(" ");
            Console.WriteLine("    0   1   2 ");
            //row 1
            Console.Write(" 0 ");
            Console.Write(" ");
            Console.Write( Board[0, 0]);
            Console.Write(" | ");
            Console.Write(Board[0, 1]);
            Console.Write(" | ");
            Console.WriteLine(Board[0, 2]);
            
            Console.WriteLine("   ___ ___ ___ ");
            //row 2
            Console.Write(" 1 ");
            Console.Write(" ");
            Console.Write(Board[1, 0]);
            Console.Write(" | ");
            Console.Write(Board[1, 1]);
            Console.Write(" | ");
            Console.WriteLine(Board[1, 2]);
            
            Console.WriteLine("   ___ ___ ___ ");
            //row 3
            Console.Write(" 2 ");
            Console.Write(" ");
            Console.Write(Board[2, 0]);
            Console.Write(" | ");
            Console.Write(Board[2, 1]);
            Console.Write(" | ");
            Console.WriteLine(Board[2, 2]);
            
            
        }
        static void playerOne(ref String [,] Board, string p1)
        {
            int R, C;
            
            Console.WriteLine("Player 1");
            Console.WriteLine("Please enter desired coordinates");
            //Row
            Console.WriteLine("Please Enter a row");
            R = Convert.ToInt32(Console.ReadLine());
            while(R < 0 || R > 2)
            {
                Console.WriteLine("Please enter a number Between 0 and 2");
                R = Convert.ToInt32(Console.ReadLine());
            }
            //Cols
            Console.WriteLine("Please Enter a Column");
            C = Convert.ToInt32(Console.ReadLine());
            while (C < 0 || C > 2)
            {
                Console.WriteLine("Please enter a number Between 0 and 2");
                C = Convert.ToInt32(Console.ReadLine());
            }
            //check for taken spot
            if (Board[R, C] != "*")
            {
                Console.WriteLine("That space is already filled, please enter new coordinates");
                Console.WriteLine("Please enter desired coordinates");
                Console.WriteLine("Please Enter a row");
                R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Column");
                C = Convert.ToInt32(Console.ReadLine());
                Board[R, C] = p1;
            }
            else
            {
                Board[R, C] = p1;
            }
            
        }
        static void playerTwo(ref String[,] Board, string p2)
        {
            int R, C;
            
            Console.WriteLine("player Two");
            Console.WriteLine("Please enter desired coordinates");
            //row
            Console.WriteLine("Please Enter a row");
            R = Convert.ToInt32(Console.ReadLine());
            while (R < 0 || R > 2)
            {
                Console.WriteLine("Please enter a number Between 0 and 2");
                R = Convert.ToInt32(Console.ReadLine());
            }
            //cols
            Console.WriteLine("Please Enter a Column");
            C = Convert.ToInt32(Console.ReadLine());
            while (C < 0 || C > 2)
            {
                Console.WriteLine("Please enter a number Between 0 and 2");
                C = Convert.ToInt32(Console.ReadLine());
            }
            //check for taken spot
            if (Board[R, C].Equals("X") || Board[R, C].Equals("O"))
            {
                Console.WriteLine("That space is already filled, please enter new coordinates");
                Console.WriteLine("Please enter desired coordinates");
                Console.WriteLine("Please Enter a row");
                R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Column");
                C = Convert.ToInt32(Console.ReadLine());
                Board[R, C] = p2;
            }
            else
            {
                Board[R, C] = p2;
            }

        }
        static Boolean CheckForWin(String[,] Board, Boolean endGame, int counter)

        {
            displayBoard(Board, counter);
            //Diagonal p1
            if (Board[0,0] == "O" && Board[1,1] == "O" && Board[2,2] == "O")
            {
                Console.WriteLine("Player One is winner");
                
                return true;
            }
            else if (Board[0, 2] == "O" && Board[1, 1] == "O" && Board[2, 0] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            //Diagonal p2
            else if (Board[0, 0] == "X" && Board[1, 1] == "X" && Board[2, 2] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (Board[0, 2] == "X" && Board[1, 1] == "X" && Board[2, 0] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            //Rows p1
            else if (Board[0, 0] == "O" && Board[0, 1] == "O" && Board[0, 2] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            else if (Board[1, 0] == "O" && Board[1, 1] == "O" && Board[1, 2] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            else if (Board[2, 0] == "O" && Board[2, 1] == "O" && Board[2, 2] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            //rows p2
            else if (Board[0, 0] == "X" && Board[0, 1] == "X" && Board[0, 2] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (Board[1, 0] == "X" && Board[1, 1] == "X" && Board[1, 2] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (Board[2, 0] == "X" && Board[2, 1] == "X" && Board[2, 2] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            //Cols p1
            else if (Board[0, 0] == "O" && Board[1, 0] == "O" && Board[2, 0] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            else if (Board[0, 1] == "O" && Board[1, 1] == "O" && Board[2, 1] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            else if (Board[0, 2] == "O" && Board[1, 2] == "O" && Board[2, 2] == "O")
            {
                Console.WriteLine("Player One is winner");
                return true;
            }
            //cols p2
            else if (Board[0, 0] == "X" && Board[1, 0] == "X" && Board[2, 0] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (Board[0, 1] == "X" && Board[1, 1] == "X" && Board[2, 1] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (Board[0, 2] == "X" && Board[1, 2] == "X" && Board[2, 2] == "X")
            {
                Console.WriteLine("Player Two is winner");
                return true;
            }
            else if (counter > 4)
            {
                Console.WriteLine("The Game is a tie");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
