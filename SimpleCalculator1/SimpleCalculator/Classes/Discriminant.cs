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

        private static void CheckValues(int iFirstVal, int iSecondVal, int iThirdVal)
        {
            if (iFirstVal < 0) iFirstVal = -iFirstVal;
            else if (iFirstVal == 0) iFirstVal = 1;
            Console.WriteLine($"{iFirstVal}x^2 + {iSecondVal}x + {iThirdVal} = 0");
            CalculationRootes();
        }

        private static int CalculationRootes()
        {

            return 0;
        }
    }
}
