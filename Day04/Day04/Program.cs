using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2212";
            string fileName = "sample.txt";
            string fullPath = Path.Combine(filePath, fileName);

            char delimiter = '#';
            //1) Open the file. will create/overwrite
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                //2) write to the file
                sw.Write("Batman rules! Aquaman does not.");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }//3) CLOSE THE FILE!
        }
    }
}
