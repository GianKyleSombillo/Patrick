using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Welcome to the BMI Calculator!");

        // Get user's weight in kilograms
        Console.Write("Enter your weight in kilograms (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Get user's height in meters
        Console.Write("Enter your height in meters (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate BMI
        double bmi = weight / (height * height);

        // Display BMI result
        Console.WriteLine($"\nYour BMI is: {bmi:F2}");

        // Determine BMI category
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }

        // End program
        Console.WriteLine("\nThank you for using the BMI Calculator.");
    }
}
