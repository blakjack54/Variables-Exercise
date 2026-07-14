using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Blake";
            int age = 28;
            char firstInitial = 'B';
            bool isLearningCSharp = true;
            double heightInFeet = 5.11;
            decimal bankBalance = 1250.75m;

            Console.WriteLine(
                $"My name is {firstName}. " +
                $"I am {age} years old. " +
                $"My first initial is {firstInitial}. " +
                $"It is {isLearningCSharp} that I am learning C#. " +
                $"My height is approximately {heightInFeet} feet, " +
                $"and my bank balance is ${bankBalance}."
            );
        }
    }
}