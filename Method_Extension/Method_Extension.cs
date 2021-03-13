using System;

namespace Method_Extension
{
    // Auch über Vererbung weiter zu gebe
    //          V ---- Class have to be static
    internal static class Method_Extension
    {
        public static void Main(string[] args)
        {
            string text = "Hallo";

            string res = text.doSomeStuff();
            Console.WriteLine(res);
        }

        public static string doSomeStuff(this string str)
        {
            return $"{str}!!!";
        }
    }
}