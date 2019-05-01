using System;

namespace SimpleCalculator.Classes
{
    public class Calculator
    {
        private enum Operation 
        {
            Addition = 1,
            Substraction,
            Muliplication,
            Divide
        }

        public static void StartProgram()
        {
            Operation operation = 0;
            int iFirstVal = 0, iSecondVal = 0;
            Console.Write("Enter a first value: ");
            while (!int.TryParse(Console.ReadLine(), out iFirstVal))
            {
                Console.Write("Enter a integer value! Second value: ");
            }
            Console.Write("Enter a second value: ");
            while (!int.TryParse(Console.ReadLine(), out iSecondVal))
            {
                Console.Write("Enter a integer value! Second value: ");
            }

            OutputOperations();
            ChooseOperation(iFirstVal, iSecondVal, operation);
            ReturnMenu();
        }

        private static void OutputOperations()
        {
            Console.WriteLine("===========Choose an operation=============");
            Console.WriteLine("Addition - enter 1");
            Console.WriteLine("Substraction - enter 2");
            Console.WriteLine("Muliplication - enter 3");
            Console.WriteLine("Divide - enter 4");
            Console.WriteLine("===========================================");
        }

        private static double ChooseOperation(int iFirstVal, int iSecondVal, Operation operation)
        {
            double result = 0.0;
            int iChooseOperation = Convert.ToInt32(operation);
            iChooseOperation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            switch (iChooseOperation)
            {
                case 1:
                    result = iFirstVal + iSecondVal;
                    Console.WriteLine($"Result = {result}");
                    break;
                case 2:
                    result = iFirstVal - iSecondVal;
                    Console.WriteLine($"Result = {result}");
                    break;
                case 3:
                    result = iFirstVal * iSecondVal;
                    Console.WriteLine($"Result = {result}");
                    break;
                case 4:
                    result = (double)iFirstVal / iSecondVal;
                    Console.WriteLine($"Result = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid operation choice!");
                    break;
            }
            return result;
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
