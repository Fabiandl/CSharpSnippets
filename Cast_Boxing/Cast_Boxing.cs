using System;

namespace Cast_Boxing
{
    internal class Cast_Boxing
    {
        static void Main(string[] args)
        {
            int n = 42;
            object o = n; // Boxing
            Console.WriteLine($"1) n={n}, o={o}"); //n=42, o=42

            int m = (int) o; // Unboxing
            Console.WriteLine($"2) m={m}"); //m = 42

            // value of o? o wird nicht geändert
            n = 5;
            Console.WriteLine($"3) n={n}, o={o}");

            
            //Wirkliche benutzung
            S s = new S() {Name = "Klaus"};
            Console.WriteLine($"4) s.Name={s.Name}");
            INameable si = s;
            Console.WriteLine($"5) si.Name={si.Name}"); // auch Klaus
            s.Name = "Hans";
            Console.WriteLine($"6) s.Name={s.Name}, si.Name={si.Name}");// si bleibt beim alten, weil es boxed ist
        }

        interface INameable
        {
            string Name { get; set; }
        }

        // compare to class
        struct S : INameable
        {
            public string Name { get; set; }
        }
    }
}