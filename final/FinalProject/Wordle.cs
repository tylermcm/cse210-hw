using System;
using System.Text;


class Wordle : AllPrograms
{
    private int score, attempt, index, randIndex;
    private bool correct = false;
    private string secretWord, hint, guess;
    private List<string> words = new List<string>{
        "salt", "doubt", "bag", "organization",
        "mother", "now", "silver", "animal", "impulse",
        "sign", "harmony", "stage", "fight", "cough",
        "comfort", "theory", "net", "liquid",
        "roof", "pin", "sugar", "fish", "hand",
        "receipt", "agreement", "sneeze", "mass", "attention"
    };

    public void PlayWordle()
    {
        Random rand = new Random();
        randIndex = rand.Next(0, words.Count - 1);
        secretWord = words[randIndex];
        words.Remove(secretWord);

        Console.WriteLine(string.Format("Your initial hint is a {0} letter word!",secretWord.Length));
        Console.WriteLine("Type 'quit' to exit the game");
        
        do{
            Console.Write("Enter your guess: ");
            guess = Console.ReadLine();
            attempt++;
            if (guess == "quit"){
                Console.WriteLine(string.Format("That's okay! The word was {0}!", secretWord));
                clearConsole();
            }

            if (guess.Length != secretWord.Length)
            {
                Console.WriteLine("You used the wrong number of letters, try again.");

            }
            else
            {
                GiveHint();
                Console.WriteLine("Your hint is {0}", hint);
            }

            if (guess == secretWord)
            {
                score++;
                correct = true;
            }

        }while (correct == false && guess != "quit");
    }
    private void GiveHint()
    {
        string[] stringHint = guess.Select(x => x.ToString()).ToArray();
        index = 0;
        StringBuilder sb = new StringBuilder(guess);
        foreach (string guessLetter in stringHint)
        {
            if (!secretWord.Contains(guessLetter))
            {
                sb[index] = '_';
            }
            index++;
            hint = sb.ToString();
        }

        index = 0;
        StringBuilder sb1 = new StringBuilder(hint);
        while (index < secretWord.Length)
        {
            if (hint[index] == secretWord[index])
            {
                sb1[index] = char.ToUpper(hint[index]);
            }
            hint = sb1.ToString();
            index++;
        }
    }
    public override string ToString()
    {
        return string.Format("Congratulations! You guessed the word!\nThe word was {0}! \nIt took you {1} attempts. Your score is now {2}", secretWord, attempt, score);

    }
}

