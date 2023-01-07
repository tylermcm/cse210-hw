using System;

class Program
{
    static void Main(string[] args)
    {   
        string input;
        do {
            guess_game();
            Console.Write("Would you like to play again? (y/n) ");
            input = Console.ReadLine();
            input.ToLower();
            Console.WriteLine(" ");
            } while (input == "y");
    }  
    private static void guess_game()
    {    
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,101);
        int guess = 0;
        int guess_count = 0;
        do {
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guess_count++;

            if (guess < magic_number) {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number) {
                Console.WriteLine("Lower");
            }

            else {
                Console.WriteLine($"You guessed it!\nIt took you {guess_count} guesses.");
            }
            
        
        } while (guess != magic_number);
    }
}