using System;
namespace Project
{
    public class HelloWorld
    {
        public static void Main()
        {
            const string InPut1 = "Enter the first integer: ";
            const string InPut2 = "Enter the second integer: ";
            const string Result = "The sum is: ";

            int Num1, Num2, Sum;

            Console.Write(InPut1);
            Num1=int.Parse(Console.ReadLine());


            Console.Write(InPut2);
            Num2 = int.Parse(Console.ReadLine());

            Sum=Num1 + Num2;
            Console.Write(Result+Sum);
        }
    }
}