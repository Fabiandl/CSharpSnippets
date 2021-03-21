using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    internal class LINQ
    {
        public static void Main(string[] args)
        {
            //Randoms
            Random random = new Random();
                                                    //20 Plätze             //für jedes der 20 ein rdm
            IEnumerable<int> alle = Enumerable.Range(1, 20).Select(n => random.Next(0, 100)).OrderBy(n => n);
                                                //Condition
            IEnumerable<int> ungerade = alle.Where(n => n % 2 != 0);
            
            //Groups
            // Gruppen ermitteln mit gleichen Rest bei Division druch 5 => Größe ausgeben der Gruppen
            var groups =
                from n in alle
                group n by n % 5
                into g
                orderby g.Key
                select new {rem = g.Key, cnt = g.Count()};

            
            //XML Lesen
            string fileName = "../../../V_LINQ/simple.xml";
            string[] lines = File.ReadAllLines(fileName);
            var xmlWaffles = lines.Where(n => n.Contains("name")).Where(line => line.Contains("Waffles")).Select(n => n.Substring(n.IndexOf(">")+1,n.IndexOf("Waffles")- n.IndexOf(">")+6));
            Console.WriteLine($"Alle Waffles : {string.Join(",",xmlWaffles)}");

            lines.OrderBy(n => n);
            lines.OrderByDescending(n => n);
        }
    }
}