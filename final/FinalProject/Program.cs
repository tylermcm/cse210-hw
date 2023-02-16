using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do{
            Menu menu = new Menu();
            choice = menu.DisplayMainMenu();
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    int gameSelection = menu.DisplayGamesMenu();
                    switch (gameSelection)
                    {
                        case 1:
                            Console.Clear();
                            MontyHall mh = new MontyHall();
                            mh.PlayMontyHall();
                            break;
                        case 2:
                            Console.Clear();
                            TicTacToe tic = new TicTacToe();;
                            tic.PlayGame();
                            break;
                        case 3:
                            Console.Clear();
                            Wordle wordle = new Wordle();
                            wordle.PlayWordle();
                            break; 
                        case 4:
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    AllPrograms programs = new AllPrograms();
                    Console.Clear();
                    int calcSelection = menu.DisplayCalculatorMenu();
                    switch (calcSelection)
                    {
                        case 1:
                            Console.Clear();
                            LoanAmortization loan = new LoanAmortization();
                            loan.DisplayTable();
                            break;
                        case 2:
                            Console.Clear();
                            TireVolume volume = new TireVolume();
                            volume.DisplayVolume();
                            break;
                        case 3:
                            Console.Clear();
                            WindChill chill = new WindChill();
                            chill.DisplayWindChill();
                            break;
                        case 4:
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }while (choice != 3);
    }
}