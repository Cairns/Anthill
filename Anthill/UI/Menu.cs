using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.UI
{
    public class Menu
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Factorial digit sum");
            Console.WriteLine("2) Even fibonacci numbers");
            Console.WriteLine("3) Multiples of 3 or 5");
            Console.WriteLine("");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
