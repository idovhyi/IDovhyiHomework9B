﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IDovhyiHomework9B
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fileStrings = new List<string>();

            string readPath = @"C:\Ihor\Study\SoftServe\Homework\IDovhyiHomework9\IDovhyiHomework9\Program.cs";
            using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null) fileStrings.Add(line);
            }

            List<int> stringsCount = new List<int>();
            foreach (string line in fileStrings) stringsCount.Add(line.Length);
            string writePath1 = @"C:\Ihor\Study\SoftServe\Homework\IDovhyiHomework9B\stringsCount.txt";
            using (StreamWriter sw = new StreamWriter(writePath1, false, System.Text.Encoding.Default))
            {
                foreach (int value in stringsCount)
                {
                    sw.WriteLine(value);
                }
            }

            Console.WriteLine("The longest line:" + fileStrings.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));
            Console.WriteLine("The shortest line:" + fileStrings.Aggregate("", (min, cur) => min.Length < cur.Length ? min : cur));


            string writePath2 = @"C:\Ihor\Study\SoftServe\Homework\IDovhyiHomework9B\var.txt";
            using (StreamWriter sw = new StreamWriter(writePath2, false, System.Text.Encoding.Default))
            {
                foreach (string line in fileStrings)
                {
                    if (line == "var") sw.WriteLine(line);
                }
            }
        }
    }
}
