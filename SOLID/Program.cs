using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExecSingleResponsibilityPrinciple();

            Console.ReadLine();
        }

        private static void ExecSingleResponsibilityPrinciple()
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persisentece();
            var filename = @"c:\temp\journal.txt";
            p.SavetoFile(j, filename, true);

            Process.Start(filename);
        }
    }

    #region Single Responsibility Principle

    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
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

        // breaks single responsibility principle \/;
        //public void Save(string filename)
        //{
        //    File.WriteAllText(filename, ToString());
        //}

        //public static Journal Load(string filename)
        //{

        //}

        //public void Load(Uri uri)
        //{

        //}
    }

    // handles the responsibility of persisting objects;
    public class Persisentece
    {
        public void SavetoFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }
    #endregion
}
