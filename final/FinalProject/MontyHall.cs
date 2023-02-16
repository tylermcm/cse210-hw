using System;


class MontyHall : AllPrograms
{
    Random random = new Random();
    private int wins, losses, iterations, choice, keepDoor, leftDoor, rightDoor;
    private bool win = false, output;
    private string playAgain;

    public void PlayMontyHall()
    {
        do{
            wins = 0; losses = 0; iterations = 0;
            DisplayGetIterations();
            Console.Write("\nEnter 1 to ALWAYS change doors\nEnter 2 to NEVER change\nEnter 3 RANDOMLY choose at each iteration\n\nChoice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    for (int i = 0; i < iterations; i++)
                    {
                        int changeDoor = 1;
                        output = CheckWin(random.Next(3), changeDoor, random.Next(3), 0);
                        if (output == true)
                            wins++;
                        else
                            losses++;
                    }
                    break;
                case 2:
                    for (int i = 0; i < iterations; i++)
                    {
                        int changeDoor = 0;
                        output = CheckWin(random.Next(3), changeDoor, random.Next(3), 0);
                        if (output == true)
                            wins++;
                        else
                            losses++;
                    }
                    break;
                case 3:
                    for (int i = 0; i < iterations; i++)
                    {
                        int changeDoor = random.Next(2);;
                        output = CheckWin(random.Next(3), changeDoor, random.Next(3), 0);
                        if (output == true)
                            wins++;
                        else
                            losses++;
                    }
                    break;
            }
            Console.WriteLine(string.Format("After {0} iterations, you won {1} times, and lost {2} times!", iterations, wins, losses));
            Console.Write("Would you like to play again? (y/n): ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        } while(playAgain == "y");
        clearConsole();
    }
    
    private bool CheckWin(int pickedDoor, int changeDoor, int winningDoor, int doorToRemove)
    {
        switch (pickedDoor)
        {
            case 0: 
                leftDoor = 1; 
                rightDoor = 2; 
                break;
            case 1: 
                leftDoor = 0; 
                rightDoor = 2; 
                break;
            case 2: 
                leftDoor = 0; 
                rightDoor = 1; 
                break;
        }

        keepDoor = doorToRemove == 0 ? rightDoor : leftDoor;
        
        if (changeDoor == 0)
        {
            win = winningDoor == pickedDoor;
        }
        else
        {
            win = winningDoor != keepDoor;
        }

        return win;
    }

    private int getIterations()
    {
        return iterations;
    }
    private void DisplayGetIterations()
    {
        Console.Write("How many iterations would you like to run? ");
        iterations = int.Parse(Console.ReadLine());
    }
}

