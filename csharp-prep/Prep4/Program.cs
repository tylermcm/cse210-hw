using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int input = -1;
        do {
            Console.Write("Enter number: ");
            string number_input = Console.ReadLine();
            input = int.Parse(number_input);
            if (input != 0){
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: " + Math.Round(average, 4));

        int max = numbers.Max();
        Console.WriteLine($"The largest number in the list is: {max}");
    }
}