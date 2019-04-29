using System;

namespace SimpleCalculator.Classes
{
    public class Discriminant
    {

        public static void StartProgram()
        {
            Console.WriteLine("Enter a three X1, X2, X3:");
            int iFirstVal = Convert.ToInt32(Console.ReadLine());
            int iSecondVal = Convert.ToInt32(Console.ReadLine());
            int iThirdVal = Convert.ToInt32(Console.ReadLine());
            CheckValues(iFirstVal, iSecondVal, iThirdVal);
        }

        private static void CheckValues(int a, int b, int c)
        {
            if (a < 0) a = -a;
            else if (a == 0) a = 1;
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            CalculationRootes(a, b, c);
        }

        private static void CalculationRootes(int a, int b, int c)
        {
            double disc = 0;
            double x1 = 0, x2 = 0;
            disc = (int)(Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine($"Discriminant = {disc}");

            if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine($"First roote = {x1}");
                Console.WriteLine($"Second roote = {x2}");
            }
            else if (disc == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"First roote = {x1}");
            } else if(disc < 0) Console.WriteLine("No roots");
            ReturnMenu();
        }

        private static void ReturnMenu()
        {
            byte bExit = 0;
            Console.WriteLine(" ");

            Console.WriteLine("Do you want to return to menu?");
            Console.WriteLine("===============================");
            Console.WriteLine("Yes - 1");
            Console.WriteLine("No - 0");
            Console.WriteLine("===============================");

            bExit = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(" ");

            if (bExit == 1) Program.ShowMenu();
            else if (bExit == 0) StartProgram();
            else ReturnMenu();
        }

    }
}
