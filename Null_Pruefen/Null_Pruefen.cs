using System;
using System.Collections.Generic;

namespace Null_Pruefen
{
    internal class Null_Pruefen
    {
        public static void Main(string[] args)
        {
            int isnotnull = 0;          // can only hold an integer number, i.e.
            //int isnull = null;        // is not possible, but ...
            int? isnull = null;         // here it is; note the "?"
            
            
            int? x = null;
            // set y to x if x is NOT null
            // otherwise, if x = null, set y to -1.
            int y = x ?? -1;

            
                        //Prüft ob die Methode Null ist, falls ja => 0
            var rnd = MethodWithReturn()?.Next() ?? 0;
            
            
            //Liste NULL prüfung
            List<int> numbers = null;
            //Falls numbers == null => mach neue Liste
            numbers ??= new List<int>();
            
            //int "i" ist jetzt NULL-Able
            int? i = null;
            numbers.Add(i ??= 17); //Falls null => 17
        }

        public static Random MethodWithReturn()
        {
            return new Random();
        }
    }
}