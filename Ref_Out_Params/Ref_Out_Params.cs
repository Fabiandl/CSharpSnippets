using System;

namespace KlausurSnippets
{
    internal class Ref_Out_Params
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"a = {a}, b = {b}");

            // REF => Referenz direkte Änderung am Objekt
            swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
            
            // PARAMS => freie Anzahl an Parametern
            doParamsStuff("Test", 1,2,3,4);
            
            // OUT => nicht initialisiertes kann übergeben werden
            object c;
            doOutStuff(out c);
        }

        private static void swap(ref int a, ref int b)
        {
            int tempb = b;

            b = a;
            a = tempb;
        }

        private static void doParamsStuff( string b, params int[] parameter)
        {
            Console.WriteLine($"DoStuff with param 0 = {parameter[0]}");
        }
        
        
        private static void doOutStuff(out object o)
        {
            o = new object();
        }
    }
}