using System;

namespace Daten_Typen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // strings and characters
            string s = "Hallo";
            char c = 'X';
            
            // floating point variables
            float f = 1.2f;
            double d = 2.3;
            decimal z = 3.4m;           // e.g. currency (Währungen)
            
            // byte und signed byte (s)
            byte b = 0x12;
            sbyte sb = -0x13;
            
            // integer variables, signed and unsigned (u)
            int n0 = -42;
            uint n1 = 42;
            long l0 = -43;
            ulong l1 = 0x12;            // hexadecimal notation
            
            // logical
            bool b0 = false;
            bool b1 = true;
            
            // math functions
            double d1 = 2.0;
            double d2 = Math.Abs(d1 - 1.5);
            double d3 = Math.PI;                // a constant
            double d4 = Math.Sin(d3);           // not declared for decimal
            double d5 = Math.Sqrt(d4);
            
            // note: some functions are defined for double only
            double d6 = 0.85;
            int m = (int)Math.Floor(d6 * 10.0);  // greatest int-number below or equal
            
            //======================== DATE ==============================
            //DateTime dtdtdtdt0;
            DateTime dt0 = new DateTime(2013, 02, 18, 10, 15, 23);      // new instance
            DateTime dt1 = dt0.AddDays(2);
            Console.WriteLine("dt0:   '" + dt0 + "'");
            Console.WriteLine("dt1:   '" + dt1 + "'");
            Console.WriteLine("day:   '" + dt1.DayOfWeek + "'");
            Console.WriteLine("day:   '" + dt1.ToUniversalTime() + "'");
            
            //====================== RANDOM ==============================
            Random rand = new Random();
            int n2 = rand.Next();               // non-negative
            int n3 = rand.Next(5);              // excl. upper bound
            int n4 = rand.Next(1, 4);           // incl. lower bound, excl. upper bound
            double f1 = rand.NextDouble();      // >=0.0 but <1.0
        }
    }
}