using System;

class AllPrograms
{

    public void clearConsole()
    {
        for (var i = 5; i >= 0; i--)
        {
            Console.Write("\rOutput will display for {0} second(s)", i);
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
}