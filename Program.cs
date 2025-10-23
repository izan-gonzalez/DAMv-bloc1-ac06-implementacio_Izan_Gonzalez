using System;
namespace Project
{
    public class Is_Natural
    {
        public static void Main()
        {
            const string Input = "Exter a value to check if it's within interval: ";
            const string Ok = "is within the interval (5, 50)";
            const string Ko = "is NOT whithin the interval";

            int Num;

            Console.Write(Input);

            Num = int.Parse(Console.ReadLine());

            if ((Num > 5) && (Num < 50))
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