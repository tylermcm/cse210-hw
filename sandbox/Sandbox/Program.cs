using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        var s = "12345";
        var result = s.ToArray();
        var randomIds = Enumerable.Range(0, s.Length).OrderBy(x => rnd.Next()).Take(3);
        foreach (var id in randomIds)
        {
            result[id] = '*';
        }
        var stringResult = String.Join("", result);
        Console.WriteLine(stringResult);
        }    
}
