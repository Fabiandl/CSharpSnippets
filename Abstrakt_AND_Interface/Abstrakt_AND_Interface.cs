using System;
using System.Collections.Generic;

namespace Abstrakt_AND_Interface
{
    internal class Abstrakt_AND_Interface
    {
        //================================== ABSTRAKT
        abstract class Car
        {
            private int speed;
            public int Speed
            {
                get { return this.speed; }
                set { this.speed = (value > 0) ? value : 0; }
            }

            protected Car(int v) { this.Speed = v; }

            public abstract void drive();
        }
        
        class BMW : Car
        {
            public BMW(int v) : base(v) { }

            public override void drive()
            {
                Console.WriteLine("drive a BMW!");
            }
        }
        
        //================================ ABSTRAKT Liste
        public class myClass : List<string>
        {

            public void doStuffWithList()
            {
                this.Add("SMTH");
            }
        }
        
        //================================ INTERFACE
        interface IDriveable
        {
            void drive();
        }
        
        class Bobbycar : IDriveable
        {
            public void drive()
            {
                Console.WriteLine("drive a Bobbycar!");
            }
        }
        
    }
}