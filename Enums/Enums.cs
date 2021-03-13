using System;

namespace Enums
{
    internal class Enums
    {
        enum Cards { Seven = 7, Eight, Nine, Ten, Knave = 20, Queen, King, Ass = 100, As = 100 };
        
        public static void Main(string[] args)
        {
            Cards q = Cards.Queen;
            Cards x = (Cards)9;   //Nine
            Cards y = (Cards) 11; //11
            
            
            // enumes are best suited for switch (switch see later)
            switch (y)
            {
                case Cards.As:
                    Console.WriteLine("As");
                    break;
                default:
                    Console.WriteLine("no As");
                    break;
            }
        }
    }
}