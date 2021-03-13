using System;

namespace Virtual_Override
{
    internal class Virtual_Override
    {
        static void Main(string[] args)
        {
            A a = new A(12);
            B b = new B();
            A a2 = new B();
            
            a.M1();     //is A
            a.M2();     //is A
            b.M1();     //is B, weil direktes B
            b.M2();     //is B
            a2.M1();    //is B, weil kein virtual => call auf A
            a2.M2();    //is B, virtual call auf B
        }
    }
    
    class A
    {
        private int n;
        
        public A(int n) { this.n = n; }
        
        public void M1() { Console.WriteLine("A.M1"); }
        
        //Häufig wenn ggf. override
        public virtual void M2() { Console.WriteLine("A.M2"); }
    }
    
    class B : A
    {
        public B() : base(5) { }

        // Andere Methode als Override
        public new void M1() { Console.WriteLine("B.M1"); }

        public override void M2() { Console.WriteLine("B.M2"); }
    }
}