using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            char r1c1 = ' ', r1c2 = ' ', r1c3 = ' ', r2c1 = ' ', r2c2 = ' ', r2c3 = ' ', r3c1 = ' ', r3c2 = ' ', r3c3 = ' ';
            int row, column;
            int player = 1;  /* Player = -1 means computer wins the game
                              * Player = 0  means user entered a wrong input
                              * Player = 1  means it is user's turn
                              * Player = 2  means it is computer's turn
                              */
            int tour = 1;
            int level;
            int loop = 1;
            Console.WriteLine("       Tic - Tac - Toe       ");
            Console.Write("\nPlease enter the degree of difficulty\n\n  1.Easy\n  2.Medium\n  3.Hard   --> ");
            level = Convert.ToInt32(Console.ReadLine());
            while (level < 1 || level > 3)
            {
                Console.WriteLine("\nWrong input!\n");
                Console.Write("Please enter the degree of difficulty\n\n  1.Easy\n  2.Medium\n  3.Hard   --> ");
                level = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n       C  O  L  U  M  N\n     *******************\n     *     *     *     *\n  R  *  " + r1c1 + "  *  " + r1c2 + "  *  " + r1c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  O  *  " + r2c1 + "  *  " + r2c2 + "  *  " + r2c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  W  *  " + r3c1 + "  *  " + r3c2 + "  *  " + r3c3 + "  *\n     *     *     *     *\n     *******************"); 
            while (loop == 1)
            {               
                Console.WriteLine("\n--- Tour " + tour + " --------------------------\n");
                Console.Write("  ---> X plays\n\nPlease enter the row : ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the column : ");
                column = Convert.ToInt32(Console.ReadLine());
                if ((row > 3 || row < 0) || (column > 3 || column < 0))
                {
                    Console.WriteLine("\nPlease enter valid numbers!");
                    player = 1; 
                    tour--;
                }

                // ---------------------------------------------------------------------------------

                // User can place a mark for any 9 field.

                else if (row == 1 && column == 1 && r1c1 == ' ')
                {
                    r1c1 = 'X';
                    player = 2;
                }
                else if (row == 1 && column == 2 && r1c2 == ' ')
                {
                    r1c2 = 'X';
                    player = 2;
                }
                else if (row == 1 && column == 3 && r1c3 == ' ')
                {
                    r1c3 = 'X';
                    player = 2;
                }
                else if (row == 2 && column == 1 && r2c1 == ' ')
                {
                    r2c1 = 'X';
                    player = 2;
                }
                else if (row == 2 && column == 2 && r2c2 == ' ')
                {
                    r2c2 = 'X';
                    player = 2;
                }
                else if (row == 2 && column == 3 && r2c3 == ' ')
                {
                    r2c3 = 'X';
                    player = 2;
                }
                else if (row == 3 && column == 1 && r3c1 == ' ')
                {
                    r3c1 = 'X';
                    player = 2;
                }
                else if (row == 3 && column == 2 && r3c2 == ' ')
                {
                    r3c2 = 'X';
                    player = 2;
                }
                else if (row == 3 && column == 3 && r3c3 == ' ')
                {
                    r3c3 = 'X';
                    player = 2;
                }
                else
                    player = 0; // It means user tryed to place a mark in a non empty field. 

                // End of the user's turn!

                // ---------------------------------------------------------------------------------

                // User can win the game in 8 conditions.

                if ((r1c1 == 'X' && r1c2 == 'X' && r1c3 == 'X') || (r2c1 == 'X' && r2c2 == 'X' && r2c3 == 'X') || (r3c1 == 'X' && r3c2 == 'X' && r3c3 == 'X') || (r1c1 == 'X' && r2c1 == 'X' && r3c1 == 'X') || (r1c2 == 'X' && r2c2 == 'X' && r3c2 == 'X') || (r1c3 == 'X' && r2c3 == 'X' && r3c3 == 'X') || (r1c1 == 'X' && r2c2 == 'X' && r3c3 == 'X') || (r1c3 == 'X' && r2c2 == 'X' && r3c1 == 'X'))
                {
                    Console.WriteLine("\n       C  O  L  U  M  N\n     *******************\n     *     *     *     *\n  R  *  " + r1c1 + "  *  " + r1c2 + "  *  " + r1c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  O  *  " + r2c1 + "  *  " + r2c2 + "  *  " + r2c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  W  *  " + r3c1 + "  *  " + r3c2 + "  *  " + r3c3 + "  *\n     *     *     *     *\n     *******************");
                    Console.WriteLine("\nCongratulations! You win!");
                    loop = 0;                    
                }

                // ---------------------------------------------------------------------------------

                // The computer plays

                else if (player == 2)
                {
                    
                    // -----------------------------------------------------
                    //      For Easy Level

                    if (level == 1)
                    {
                        if (r3c2 == ' ')
                        {
                            r3c2 = 'O';
                            Console.WriteLine("\n  ---> O plays (3,2)\n");
                        }
                        else if (r2c3 == ' ')
                        {
                            r2c3 = 'O';
                            Console.WriteLine("\n  ---> O plays (2,3)\n");
                        }
                        else if (r2c1 == ' ')
                        {
                            r2c1 = 'O';
                            Console.WriteLine("\n  ---> O plays (2,1)\n");
                        }
                        else if (r1c2 == ' ')
                        {
                            r1c2 = 'O';
                            Console.WriteLine("\n  ---> O plays (1,2)\n");
                        }
                        else if (r3c3 == ' ')
                        {
                            r3c3 = 'O';
                            Console.WriteLine("\n  ---> O plays (3,3)\n");
                        }
                        else if (r3c1 == ' ')
                        {
                            r3c1 = 'O';
                            Console.WriteLine("\n  ---> O plays (3,1)\n");
                        }
                        else if (r1c3 == ' ')
                        {
                            r1c3 = 'O';
                            Console.WriteLine("\n  ---> O plays (1,3)\n");
                        }
                        else if (r1c1 == ' ')
                        {
                            r1c1 = 'O';
                            Console.WriteLine("\n  ---> O plays (1,1)\n");
                        }
                        else if (r2c2 == ' ')
                        {
                            r2c2 = 'O';
                            Console.WriteLine("\n  ---> O plays (2,2)\n");
                        }
                    }

                        // -----------------------------------------------------
                        //      For Medium and Hard levels (24 conditions to win)

                    else if (r1c1 == 'O' && r1c2 == 'O' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                        player = -1;
                    }
                    else if (r1c2 == 'O' && r1c3 == 'O' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                        player = -1;
                    }
                    else if (r1c1 == 'O' && r1c3 == 'O' && r1c2 == ' ')
                    {
                        r1c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,2)\n");
                        player = -1;
                    }
                    else if (r2c1 == 'O' && r2c2 == 'O' && r2c3 == ' ')
                    {
                        r2c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,3)\n");
                        player = -1;
                    }
                    else if (r2c2 == 'O' && r2c3 == 'O' && r2c1 == ' ')
                    {
                        r2c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,1)\n");
                        player = -1;
                    }
                    else if (r2c1 == 'O' && r2c3 == 'O' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                        player = -1;
                    }
                    else if (r3c1 == 'O' && r3c2 == 'O' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                        player = -1;
                    }
                    else if (r3c2 == 'O' && r3c3 == 'O' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                        player = -1;
                    }
                    else if (r3c1 == 'O' && r3c3 == 'O' && r3c2 == ' ')
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                        player = -1;
                    }
                    else if (r1c1 == 'O' && r2c1 == 'O' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                        player = -1;
                    }
                    else if (r2c1 == 'O' && r3c1 == 'O' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                        player = -1;
                    }
                    else if (r1c1 == 'O' && r3c1 == 'O' && r2c1 == ' ')
                    {
                        r2c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,1)\n");
                        player = -1;
                    }
                    else if (r1c3 == 'O' && r2c3 == 'O' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                        player = -1;
                    }
                    else if (r2c3 == 'O' && r3c3 == 'O' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                        player = -1;
                    }
                    else if (r1c3 == 'O' && r3c3 == 'O' && r2c3 == ' ')
                    {
                        r2c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,3)\n");
                        player = -1;
                    }
                    else if (r1c2 == 'O' && r2c2 == 'O' && r3c2 == ' ')
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                        player = -1;
                    }
                    else if (r2c2 == 'O' && r3c2 == 'O' && r1c2 == ' ')
                    {
                        r1c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,2)\n");
                        player = -1;
                    }
                    else if (r1c2 == 'O' && r3c2 == 'O' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                        player = -1;
                    }
                    else if (r1c1 == 'O' && r2c2 == 'O' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                        player = -1;
                    }
                    else if (r2c2 == 'O' && r3c3 == 'O' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                        player = -1;
                    }
                    else if (r1c1 == 'O' && r3c3 == 'O' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                        player = -1;
                    }
                    else if (r1c3 == 'O' && r2c2 == 'O' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                        player = -1;
                    }
                    else if (r2c2 == 'O' && r3c1 == 'O' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                        player = -1;
                    }
                    else if (r3c1 == 'O' && r1c3 == 'O' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                        player = -1;
                    }
                    
                    // End of 24 conditions to win
                    //------------------------------------------------------------

                    //------------------------------------------------------------
                    // For only Hard Level (Extra conditions to do not lose)

                    else if ((level == 3) && ((r1c1 == 'X' && r1c2 == ' ' && r1c3 == ' ' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == ' ' && r3c1 == ' ' && r3c2 == ' ' && r3c3 == 'X') || (r1c1 == ' ' && r1c2 == ' ' && r1c3 == 'X' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == ' ' && r3c1 == 'X' && r3c2 == ' ' && r3c3 == ' ')))
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                    }
                    else if ((level == 3) && ((r1c1 == 'X' && r1c2 == ' ' && r1c3 == ' ' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == ' ' && r3c1 == ' ' && r3c2 == 'X' && r3c3 == ' ') || (r1c1 == ' ' && r1c2 == ' ' && r1c3 == 'X' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == ' ' && r3c1 == ' ' && r3c2 == 'X' && r3c3 == ' ')))
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                    }
                    else if ((level == 3) && ((r1c1 == ' ' && r1c2 == ' ' && r1c3 == ' ' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == 'X' && r3c1 == 'X' && r3c2 == ' ' && r3c3 == ' ') || (r1c1 == ' ' && r1c2 == ' ' && r1c3 == ' ' && r2c1 == ' ' && r2c2 == 'O' && r2c3 == 'X' && r3c1 == ' ' && r3c2 == 'X' && r3c3 == ' ')))
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                    }

                    //-------------------------------------------------------------------3
                    //      For Medium and Hard levels (24 conditions to do not lose)
 
                    else if (r1c1 == 'X' && r1c2 == 'X' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                    }
                    else if (r1c2 == 'X' && r1c3 == 'X' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                    }
                    else if (r1c1 == 'X' && r1c3 == 'X' && r1c2 == ' ')
                    {
                        r1c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,2)\n");
                    }
                    else if (r2c1 == 'X' && r2c2 == 'X' && r2c3 == ' ')
                    {
                        r2c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,3)\n");
                    }
                    else if (r2c2 == 'X' && r2c3 == 'X' && r2c1 == ' ')
                    {
                        r2c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,1)\n");
                    }
                    else if (r2c1 == 'X' && r2c3 == 'X' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                    }
                    else if (r3c1 == 'X' && r3c2 == 'X' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                    }
                    else if (r3c2 == 'X' && r3c3 == 'X' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                    }
                    else if (r3c1 == 'X' && r3c3 == 'X' && r3c2 == ' ')
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                    }
                    else if (r1c1 == 'X' && r2c1 == 'X' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                    }
                    else if (r2c1 == 'X' && r3c1 == 'X' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                    }
                    else if (r1c1 == 'X' && r3c1 == 'X' && r2c1 == ' ')
                    {
                        r2c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,1)\n");
                    }
                    else if (r1c3 == 'X' && r2c3 == 'X' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                    }
                    else if (r2c3 == 'X' && r3c3 == 'X' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                    }
                    else if (r1c3 == 'X' && r3c3 == 'X' && r2c3 == ' ')
                    {
                        r2c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,3)\n");
                    }
                    else if (r1c2 == 'X' && r2c2 == 'X' && r3c2 == ' ')
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                    }
                    else if (r2c2 == 'X' && r3c2 == 'X' && r1c2 == ' ')
                    {
                        r1c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,2)\n");
                    }
                    else if (r1c2 == 'X' && r3c2 == 'X' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                    }
                    else if (r1c1 == 'X' && r2c2 == 'X' && r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                    }
                    else if (r2c2 == 'X' && r3c3 == 'X' && r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                    }
                    else if (r1c1 == 'X' && r3c3 == 'X' && r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                    }
                    else if (r1c3 == 'X' && r2c2 == 'X' && r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                    }
                    else if (r2c2 == 'X' && r3c1 == 'X' && r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                    }
                    else if (r3c1 == 'X' && r1c3 == 'X' && r3c1 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                    }

                    // End of 24 conditions to do not lose
                    //---------------------------------------------------------

                    //---------------------------------------------------------
                    // To place a mark in empty fields in order of priorities (9 conditions)

                    else if (r2c2 == ' ')
                    {
                        r2c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,2)\n");
                    }
                    else if (r1c1 == ' ')
                    {
                        r1c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,1)\n");
                    }
                    else if (r1c3 == ' ')
                    {
                        r1c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,3)\n");
                    }
                    else if (r3c1 == ' ')
                    {
                        r3c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,1)\n");
                    }
                    else if (r3c3 == ' ')
                    {
                        r3c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,3)\n");
                    }
                    else if (r1c2 == ' ')
                    {
                        r1c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (1,2)\n");
                    }
                    else if (r2c1 == ' ')
                    {
                        r2c1 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,1)\n");
                    }
                    else if (r2c3 == ' ')
                    {
                        r2c3 = 'O';
                        Console.WriteLine("\n  ---> O plays (2,3)\n");
                    }
                    else if (r3c2 == ' ')
                    {
                        r3c2 = 'O';
                        Console.WriteLine("\n  ---> O plays (3,2)\n");
                    }

                    //   End of 9 conditions
                    //---------------------------------------------------------------

                    Console.WriteLine("\n       C  O  L  U  M  N\n     *******************\n     *     *     *     *\n  R  *  " + r1c1 + "  *  " + r1c2 + "  *  " + r1c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  O  *  " + r2c1 + "  *  " + r2c2 + "  *  " + r2c3 + "  *\n     *     *     *     *\n     *******************\n     *     *     *     *\n  W  *  " + r3c1 + "  *  " + r3c2 + "  *  " + r3c3 + "  *\n     *     *     *     *\n     *******************");

                    //---------------------------------------------------------------
                }  // End of if statement (Computer's turn)
                    
                    if (player == 0)
                    {
                        Console.WriteLine("\nWrong input!");
                        tour--;
                    }
                    else if (player == -1)
                    {
                        Console.WriteLine("\nYou lost!");
                        loop = 0;
                    }
                    else if (loop != 0 && r1c1 != ' ' && r1c2 != ' ' && r1c3 != ' ' && r2c1 != ' ' && r2c2 != ' ' && r2c3 != ' ' && r3c1 != ' ' && r3c2 != ' ' && r3c3 != ' ')
                    {       //if loop = 0, then the user may win the game
                        Console.WriteLine("\nThe game is over in a tie!");
                        loop = 0;
                    }
          
                tour++;
            
            } //  End of while 

            Console.ReadLine();
        }
    }
}

