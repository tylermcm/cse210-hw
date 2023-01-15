using System;


public class Prompt
{
    public List<string> _entries = new List<string>();
    public  List<string> _prompt = new List<string> 
    {
        "What was the funniest things to happen to you this week?",
        "What is the most inspirational quote you have heard?",
        "Who has been the greatest influence in your life?",
        "What has been the best book your read recently and why?",
        "If you could experience anything again like it was the first time, what would it be and why?"
    };


    public void Prompts()
    {
        Random rand = new Random();
        int randIndex = rand.Next(0, _prompt.Count - 1);
        string random = _prompt[randIndex];
        Console.WriteLine(random);
        _entries.Add(random);
        _prompt.Remove(random);
    }

        public void Write()
    {   
        Console.Write("> ");
        string entry = Console.ReadLine();
        _entries.Add(entry);

    }



}
    

