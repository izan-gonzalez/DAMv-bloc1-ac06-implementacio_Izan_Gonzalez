using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Project
{
    public class Euros_to_Dolars
    {
        public static void Main()
        {
            const string Input1= "Enter the first number: ";
            const string Input2= "Enter the second number: ";
            const string Input3= "Enter the third number: ";
            const string Result = "The average is: ";

            int Num1, Num2, Num3, Average;

            Console.Write(Input1);
            Num1= int.Parse(Console.ReadLine());

            Console.Write(Input2);
            Num2 = int.Parse(Console.ReadLine());

            Console.Write(Input3);
            Num3 = int.Parse(Console.ReadLine());

            Average = (Num1 + Num2 + Num3) / 3;
            Console.Write(Result+Average);
        }
    }
}