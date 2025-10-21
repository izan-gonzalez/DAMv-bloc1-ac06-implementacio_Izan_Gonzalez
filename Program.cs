using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;
namespace Project
{
    public class Euros_to_Dolars
    {
        public static void Main()
        {
            const double Exchange = 1.12;
            const string Input= "Enter amount in euros: ";
            const string Result = "Amount in dollars: ";

            double Euros, Dollars;

            Console.Write(Input);
            Euros= double.Parse(Console.ReadLine());

            Dollars = Euros * Exchange;

            Console.Write(Result+Dollars);
        }
    }
}