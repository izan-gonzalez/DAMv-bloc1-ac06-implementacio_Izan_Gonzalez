using System;
namespace Project
{
    public class HelloWorld
    {
        public static void Main()
        {
            const string Input1 = "Enter temperature in Celsius: ";
            const string Result = "Temperature in Kelvin: ";

            double Celsius, Kelvin;

            Console.Write(Input1);
            Celsius= double.Parse(Console.ReadLine());
            Kelvin = Celsius + 273.15;

            Console.Write(Result+Kelvin);
        }
    }
}