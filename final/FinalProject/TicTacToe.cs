using System;
using System.Collections.Generic;
using System.Diagnostics;

class TicTacToe : AllPrograms
{
    private char[] boardArray;
    private int choice, player = 1;
    private bool? win;
    private string playAgain;
    public void PlayGame()
    {
        do{
            boardArray = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' , '9'};
            do{
                Console.Clear();
                DisplayGameBoard();
                choice = int.Parse(Console.ReadLine());

                if (Enumerable.Range(1, 9).Contains(choice))
                {
                    if (boardArray[choice] != 'X' && boardArray[choice] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            boardArray[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            boardArray[choice] = 'X';
                            player++;
                        }
                    }
                }

                win = CheckGameStatus();
            }while (win != true && win != null);
            Console.Clear();
            DisplayGameBoard();

            if (win == true)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("You tied.");
            }

            Console.Write("Would you like to play again?(y/n) ");
            playAgain = Console.ReadLine();

        }while (playAgain == "y");
        clearConsole();
    }

    private void DisplayGameBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[1], boardArray[2], boardArray[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[4], boardArray[5], boardArray[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[7], boardArray[8], boardArray[9]);
        Console.WriteLine("     |     |      ");
    }

    private bool? CheckGameStatus()
    {
        if (boardArray[1] == boardArray[2] && boardArray[2] == boardArray[3] ||
            boardArray[4] == boardArray[5] && boardArray[5] == boardArray[6] ||
            boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8] ||
            boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7] ||
            boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8] ||
            boardArray[3] == boardArray[6] && boardArray[6] == boardArray[9] ||
            boardArray[1] == boardArray[5] && boardArray[5] == boardArray[9] ||
            boardArray[3] == boardArray[5] && boardArray[5] == boardArray[7]) 
        {
            return true;
        }
        else if(boardArray[1] != '1' && 
                boardArray[2] != '2' && 
                boardArray[3] != '3' && 
                boardArray[4] != '4' && 
                boardArray[5] != '5' && 
                boardArray[6] != '6' && 
                boardArray[7] != '7' && 
                boardArray[8] != '8' && 
                boardArray[9] != '9')
        {
            return null;
        }
        else
        {
            return false;
        }
    }
}