﻿namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"After conversion");
            Console.WriteLine($"fahreinheit {fahrenheit}");
            Console.WriteLine($"celsius {celsius}");
        }
    }
}
