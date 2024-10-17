using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporableAreasConsoleDemo
{
    internal class DisplayUtility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
