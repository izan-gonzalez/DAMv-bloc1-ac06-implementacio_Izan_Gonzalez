using System;
using System.Runtime.InteropServices;
namespace Project
{
    public class HelloWorld
    {
        public static void Main()
        {
            const string Input_Width = "Enter the width of the rectangle: ";
            const string Input_Height="Enter the height of the rectangle: ";
            const string Result = "The area of the rectangle is: ";

            double Width, Height, Area;

            Console.Write(Input_Width);
            Width= double.Parse(Console.ReadLine());

            Console.Write(Input_Height);
            Height = double.Parse(Console.ReadLine());

            Area = Width * Height;


            Console.Write(Result+Area);
        }
    }
}