using System;
using System.Collections.Generic;

namespace Enumerator
{
    //Keine Liste oder Array sondern die Möglichkeit beim letzten Aufruf der Methode wieder anzufangen
    internal class Enumerator
    {
        public static void Main(string[] args)
        {
            foreach (var x in MyEnumReverseString("Hallo"))
            {
                Console.Write(x);
            }
        }
        
        private static IEnumerable<string> MyEnumReverseString(string str)
        {
            int c = str.Length;
            while (c-- > 0)
            {   
                yield return "c=" +str.ToCharArray()[c] + " "; //nach yield wird weiter gemacht
            }
        }
    }
}