using System;


class TireVolume : AllPrograms
{
    private int width, a_ratio, diameter;

    public double volume(int _width, int _a_ratio, int _diameter)
    {
        return Math.Round((Math.PI * (Math.Pow(_width, 2) * _a_ratio * (_width * _a_ratio + 2540 * _diameter)) / 10_000_000_000),2);
    }
    public override string ToString()
    {
        return string.Format("The approximate volume is {0} liters", volume(getWidth(), getRatio(), getDiameter()));
    }

    public int getWidth()
    {
        return width;
    }
    public int getRatio()
    {
        return a_ratio;
    }
    public int getDiameter()
    {
        return diameter;
    }
    public void DisplayGetVolume()
    {
        Console.Write("Enter the width of the tire in mm (ex. 205): ");
        width = int.Parse(Console.ReadLine());
        Console.Write("Enter the aspect ratio of the tire (ex. 60): ");
        a_ratio = int.Parse(Console.ReadLine());
        Console.Write("Enter the diameter of the wheel (ex. 15): ");
        diameter = int.Parse(Console.ReadLine());
    }


}

