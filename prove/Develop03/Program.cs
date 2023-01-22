using System;

class Program
{

    static void Main(string[] args)
    {
        string book = "D&C";
        string chapter = "58";
        string verse = "42-43";
        string scriptureString = "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins- behold, he will confess them and forsake them.";
        Console.Write("Enter a scripture or press Enter to use default scripture: ");
        string scriptureStringEntry = Console.ReadLine();

        bool input = string.IsNullOrEmpty(scriptureStringEntry);
        if (input == false)
        {
            scriptureString = scriptureStringEntry;
            Console.Write("Enter the scripture reference using spaces between book, chapter, and verse: ");
            string scriptureReference = Console.ReadLine();
    
            string[] scriptureReferenceParts = scriptureReference.Split(' ');
            book = scriptureReferenceParts[0];
            chapter = scriptureReferenceParts[1];
            verse = scriptureReferenceParts[2];
            
        }



        Reference _reference = new Reference(book,chapter,verse);
        Scripture _scripture = new Scripture (_reference, scriptureString);
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
