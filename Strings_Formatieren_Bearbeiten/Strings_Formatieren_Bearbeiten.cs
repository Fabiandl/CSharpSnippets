using System;

namespace Strings_Formatieren_Bearbeiten
{
    internal class Strings_Formatieren_Bearbeiten
    {
        public static void Main(string[] args)
        {
            const string original = "Hallo 12345 Ende";
            // contains some text?
            bool b = original.Contains("Ende");
            
            // looks for position of some text
            int pos = original.IndexOf('0'); // NOT FOUND => -1
            pos = original.IndexOf('1');     // FOUND
            
            // extracts text 
            string sStart = original.Substring(pos);
                                                    //Länge des zu schneidenden
            sStart = original.Substring(pos, 5);
            
            // replaces text => Replace ALL
            sStart = original.Replace("l", "L");
            
            // converts to lower or upper case
            sStart = original.ToLower();
            sStart = original.ToUpper();
            
            // inserts or removes text 
            sStart = original.Insert(5, "!");
                                                //Länge des zu löschenden
            sStart = original.Remove(7, 3);
            
            // removes white space
            sStart = original.Trim();
            
            // use escape-seq.  \t => TAB \n => next Line
            sStart = "\\123\\456\t789";
            // use as it is given
            sStart = @"\123\456\t789";

            // splits text, assigns array elements []
            string[] a = original.Split(' ');
            string[] c = original.Split("123".ToCharArray());
            
            //==================================== FORMATIEREN ==========================================
            // https://docs.microsoft.com/de-de/dotnet/standard/base-types/standard-numeric-format-strings
            int n = 23, m = 42;
            Console.WriteLine($"Ausgabe 1: '{n:d}', " +       //Decimal
                              $"'{m,4:d}'," +               //Decimal mit 4 davor Frei
                              $" '{m,-4:d}', " +            //Decimal mit 4 danach Frei
                              $"'{m,4:####}', " +           //exakte Füllung mit #
                              $"'{m,4:0000}'");             //exakte Füllung mit # sonst "0"
            // same result
            string format = string.Format($"Ausgabe: '{n:d}', '{m,4:d}', '{m,-4:d}', '{m,4:####}', '{m,4:0000}'");
            
            // hex
            Console.WriteLine($"   Ausgabe 2: '{n:x4}'");
            
            // gerundet DOUBLE
            double d = 1.2345678;
            Console.WriteLine($"   Ausgabe 3: '{d:f}'," +   //auf Festkomme x.xx
                              $" '{d:e}'," +                //auf wissenschaftlich
                              $" {d:#.####}");              //auf Schema
            
            //String formatierung
            string s = "Text";
            Console.WriteLine($"   Ausgabe 4: '{s,10}'," +  //Füllen auf '10' von Hinten
                              $" '{s,-10}'");               //Füllen auf '10' von Vorne
        }
    }
}