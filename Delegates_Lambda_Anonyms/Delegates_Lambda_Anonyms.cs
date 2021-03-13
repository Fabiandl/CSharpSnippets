using System;
using System.Collections.Generic;

namespace Delegates_Lambda_Anonyms
{
    internal class Delegates_Lambda_Anonyms
    {
        
        //Liefert double und bekommt double
        delegate double Funktion(double d);
        delegate double F2(double d1, double d2, double d3);
        delegate bool F3(int x, double a, double b);

        private static Func<double, double, int> f4;
        
        public static void Main(string[] args)
        {
            //====================== DELEGATE
            Funktion f0 = inputDouble => inputDouble * inputDouble;
            double res = f0(2);

            F2 f2= (a, b, c) => (a + b + c);
            res = f2(1, 2, 3);
            
            //ist x zwischen a & b ?
            F3 f3 = (x, a, b) => a <= x && b >= x;

            f4 = (d, d1) =>
            {
                return Convert.ToInt32(d * d1);

            };


            //======================= ANONYMER-STUFF
            // this is an anonymous class, containing two integers
            int x_Value = 1;
            var p1 = new {x_Value = 1, y = 2};
            var p2 = p1;
            
            //======================= LAMBDA-SPECIAL-STUFF
            //Vergleich in kurz für Sort
            Comparison<String> sortBy = (a, b) => (a.Length > b.Length) ? -1 : 1;
            
            var words = new List<string> {"This", "is", "one", "simple", "list."};
            words.Sort(sortBy);
            words.Sort((a, b) => a.CompareTo(b));
        }
    }
}