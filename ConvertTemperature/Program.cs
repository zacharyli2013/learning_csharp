using System;

namespace ConvertTemperature
{
    class ConvertTemperature
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\nenter C temperature: ");
            float C = float.Parse(System.Console.ReadLine());
            float F = (C * 9/5) + 32;
            System.Console.WriteLine("the temperature in F is: "  + F);
        }
    }
}
