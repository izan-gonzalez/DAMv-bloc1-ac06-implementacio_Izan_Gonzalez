using System;
namespace Project
{
    public class Is_Natural
    {
        public static void Main()
        {
            const string Ok = "Your number is natural: ";
            const string Ko = "Your number is not natural: ";
            const string Input = "Enter a value to check if it's a natural number: ";

            int Value;
            bool isNatural;

            isNatural = false;

            Console.Write(Input);
            Value = int.Parse(Console.ReadLine());

            if ((Value >= 0) && (Value == Value))
            {
                isNatural = true;
            }
            else
            {
                isNatural = false;
            }

            if (isNatural)
            {
                Console.Write(Ok);
            }
            else
            {
                Console.Write(Ko);

            }
        }
    }
}