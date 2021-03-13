using System;

namespace Reflection
{
    internal class Reflection
    {
        static void Main(string[] args) {
            // type information of a D-object
            Type typeOfKlasse = new Klasse().GetType();

            // all class member, i.e. variables (fields), properties, methods
            foreach (var x in typeOfKlasse.GetMembers()) {
                Console.WriteLine("02) memberinfo: " + x + ", " + x.MemberType);
            }
            
            foreach (var p in typeOfKlasse.GetProperties()) {      //Klassen Properties
                Console.WriteLine("03) prop.info: " + p + ", " + p.Name);
            }

            // all methods including parameter info
            foreach (var y in typeOfKlasse.GetMethods()) {
                Console.Write("04) methodinfo: " + y);
                foreach (var m in y.GetParameters())
                    Console.Write(" " + m);
                Console.WriteLine();
            }

            // all interfaces
            foreach (var z in typeOfKlasse.GetInterfaces()) {
                Console.WriteLine("05) interfaceinfo: " + z + ", " + z.Name);
            }

            // call a method by name
            Klasse klasse = new Klasse{n = 42}; // d.g(2)
            typeOfKlasse = klasse.GetType();
            var f = typeOfKlasse.GetMethod("g");
            // if (f!=null) f.Invoke(d, new object[] {2});
            f?.Invoke(klasse, new object[] {2});
        }
        

     //======================= KLASSEN FÜR DIE Reflection
        interface I {
            void g(int m);
        }

        class Klasse : I {
            public int n;
            private string s;

            public string S {
                get { return this.s; }
                set { this.s = value; }
            }

            public int f1() { return 0; }
            private void f2(int n) { return; }
            static string f3(string s) { return s; }

            public void g(int m) { Console.WriteLine("in D:g() n*m=" + (n * m)); }
        }
    }
}