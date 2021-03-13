using System;
using System.IO;

namespace File_IO
{
    internal class File_IO
    {
        public static void Main(string[] args)
        {
            string fileName = "../../../File_IO/bundesliga-0.txt";
            
            //READ ALL lines
            string[] lines = File.ReadAllLines(fileName);

            Console.WriteLine("1) Bundesliga - clubs");
            foreach (string line in lines)
                Console.WriteLine("   line: " + line.Substring(0, 26));
            
            
            //WRITE ALL
            File.WriteAllLines(fileName.Substring(0, fileName.Length - "-0.txt".Length) + "-1.txt", lines);
            
            //STREAM READER einzel
            StreamReader reader = new StreamReader(fileName);
            
            using (reader) // Streamreader hat INTERFACE IDisposable
            {
                while (reader.Peek() != -1)
                {
                    Console.WriteLine(reader.ReadLine());  
                }
            }
            
            //STREAM WRITER einzel
            StreamWriter writer = new StreamWriter(fileName + "-2.txt");
            using (writer)  // 
            {
                foreach (string headline in new string[3])
                {
                    writer.WriteLine("club: " + headline);
                }
            }
        }
    }
}