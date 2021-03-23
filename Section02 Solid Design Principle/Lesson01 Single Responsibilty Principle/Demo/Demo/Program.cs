using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace Demo
{

    public class Jouranl
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count} {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    public class Persistence
    {
        public void SaveToFile(Jouranl j, string fileName, bool overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var j = new Jouranl();
            j.AddEntry("Testing");
            j.AddEntry("Testing2");

            WriteLine(j.ToString());


            var p = new Persistence();
            var fileName = @"D:\\testing.txt";
            p.SaveToFile(j, fileName, true);
            Console.ReadLine();
        }
    }
}
