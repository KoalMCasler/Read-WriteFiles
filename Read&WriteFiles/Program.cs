using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_WriteFiles
{
    internal class Program
    {
        static string path = @"testText.txt"; //Relative file path
        static string basicText;
        static string[] mapRows;
        static void Main()
        {
            Console.WriteLine("Reading and writing files");
            mapRows = File.ReadAllLines(path);
            for(int y = 0; y < mapRows.Length; y++)
            {
                string mapRow = mapRows[y];
                for(int x = 0; x < mapRow.Length; x++)
                {
                    char tile = mapRow[x];
                    Console.Write(tile);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
