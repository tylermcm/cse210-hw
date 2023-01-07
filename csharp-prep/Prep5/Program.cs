using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string name = Name();
        int number = Numbers();
        int square = Square(number);

        Console.WriteLine($"{name}, the square of your number is {square}");

    }
    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int Numbers()
    {
        Console.Write("Please enter your favorite number: ");
        int numbers = int.Parse(Console.ReadLine());
        return numbers;
    }
    static int Square(int number)
    {
        int square = number * number;
        return square;
    }
}