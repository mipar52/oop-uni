using System;
using System.IO;

namespace Zadatak03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string path = "/Users/milanparadina/Desktop/directoryy/test.txt";
            try
            {
                WriteFile(path, "trla baba lan");
                ReadFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            using (Miroslav miroslav = new Miroslav()) {} // kako ima IDisposable, triggera se 'Dispose'
        }

        private static void WriteFile(string path, string textToWrite)
        {
            // using -> zatvara (.Dispose()) file u finally
            // IDisposable interface
            using (StreamWriter reader = File.CreateText(path))
            {
                reader.Write(textToWrite);
            };
        }

        private static void ReadFile(string filePath)
        {
            // using -> zatvara (.Dispose()) file u finally
            // IDisposable interface
            using (StreamReader reader = File.OpenText(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            };

        }
    }
}