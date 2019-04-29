using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Classes
{
    class Maxrix
    {
        public static void StartProgram() {
            Console.WriteLine("In developing");
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
