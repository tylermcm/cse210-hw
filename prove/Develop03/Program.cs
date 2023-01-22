using System;

class Program
{

    static void Main(string[] args)
    {
        // string verse = "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins- behold, he will confess them and forsake them.";
        Reference _reference = new Reference("D&C","58","42-43");
        Scripture _scripture = new Scripture (_reference, "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins-behold, he will confess them and forsake them.");
        Memorizer _memorizer = new Memorizer(_scripture);

        string userInput = "";

        while (userInput != "quit" && _memorizer.wordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}\n", _reference.Output(), _memorizer.Output()));
            Console.WriteLine("Press Enter to hide words or quit to exit the program.");
            userInput = Console.ReadLine();
            _memorizer.removeFromList();
        } 


    }


}
