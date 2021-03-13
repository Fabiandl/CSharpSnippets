using System;

namespace Console_IO
{
    internal class Console_IO
    {
        public static void Main(string[] args)
        {
            // einfache Eingabe
            Console.Write("5) Eingabe: ");
            string s = Console.ReadLine();

            Console.WriteLine($"Eingabe ist: {s}");
        }
    }
}