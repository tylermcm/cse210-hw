using System;


class WindChill : AllPrograms
{
    private double temperature;

    public void DisplayWindChill()
    {
        DisplayGetTemperature();
        foreach (double wind in Enumerable.Range(1, 10).Select(x => x * 5))
        {
            Console.WriteLine(string.Format("At {0} degrees Fahrenheit and a windspeed of {1} mph, the windchill is {2} degrees.", getTemperature(), wind, CalculateChill(getTemperature(), wind)));
        }
        clearConsole();
    }

    private double CalculateChill(double _temperature, double _wind)
    {
        return Math.Round(35.74 + 0.6215 * (_temperature) - 35.75 * (Math.Pow(_wind, 0.16)) + 0.4275 * (_temperature) * (Math.Pow(_wind, 0.16)),2);
    }

    
    private double getTemperature()
    {
        return temperature;
    }
    private void DisplayGetTemperature()
    {
        Console.Write("What is the temperature in Fahrenheit? ");
        temperature = double.Parse(Console.ReadLine());
    }



}

