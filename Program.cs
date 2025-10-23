using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Project
{
    public class NumberWithAttempts
    {
        public static void Main()
        {
            const string Input ="Enter an integer number within the interval(2, 30):";
            const string ATTEMPTS = "Attempt of 3:";
            const string Ok = "Valid number entered: ";
            const string Ko = "Error: The number is not within the interval (2, 30). It must be between 3 and 29 (inclusive).";
            const string Lost= "You have lost. No valid number entered.";

            int Num,attempts;
            bool IsValid;


            attempts = 1;
            IsValid=false;

            while (attempts <= 3 && !IsValid)
            {
                Console.WriteLine(ATTEMPTS + attempts);
                Console.Write(Input);
                Num = int.Parse(Console.ReadLine());


                if (Num > 2 && Num < 30)
                {
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                    attempts++;
                }
            }

            if (IsValid)
            {
                Console.WriteLine(Ok);
            }
            else
            {
                Console.WriteLine(Ko);
            }
        }
    }
}