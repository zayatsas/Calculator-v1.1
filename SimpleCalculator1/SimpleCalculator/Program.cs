using System;
using SimpleCalculator.Classes;

namespace SimpleCalculator
{
    public class Program
    {
        private enum Tasks
        {
            Calculator = 1,
            Discriminant,
            Matrix
        }

        public static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {
            Console.WriteLine("================Menu=============");
            Console.WriteLine("Calculator - 1");
            Console.WriteLine("Discriminant - 2");
            Console.WriteLine("Matrix - 3 ");
            Console.WriteLine("=================================");
            Console.WriteLine("Enter a task");
            Tasks tasks = 0;
            ChooseTask(tasks);
        }

        private static void ChooseTask(Tasks tasks)
        {
            int iChooseTask = Convert.ToInt32(tasks);
            iChooseTask = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (iChooseTask)
            {
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("Running calculator");
                    Calculator.StartProgram();
                    break;
                case 2:
                    Console.WriteLine("Running discriminant");
                    Discriminant.StartProgram();
                    break;
                case 3:
                    Console.WriteLine("Running matrix");
               default:
                    Console.WriteLine("No such figure");
                    ShowMenu();
                    break;
            }
        }
    }
}
