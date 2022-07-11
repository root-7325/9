using System;
class converter
{
    static void Main()
    {
        int celsius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(celsius + 273);
        Console.WriteLine(celsius * 18 / 10 + 32);
        Console.ReadKey(true);
    }
}
