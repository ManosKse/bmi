using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me your weight:");
            string w = Console.ReadLine();
            float weight = float.Parse(w);
            Console.Write("Please give me your height:");
            string h = Console.ReadLine();
            float height = float.Parse(h);
            float bmi = weight / (height * height);
            // Console.WriteLine prints somethink to the console
            Console.WriteLine($"BMI is: {bmi}");
            Console.Read();
        }
    }
}
