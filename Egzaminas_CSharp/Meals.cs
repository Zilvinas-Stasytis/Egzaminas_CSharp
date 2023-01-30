using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;

namespace Restaurant_CSharp
{
    public class Meals
    {
        public void Meal()
        {
            StreamReader reader = null;
            if (File.Exists("patiekalai.csv"))
            {
                reader = new StreamReader(File.OpenRead("patiekalai.csv"));
                List<string> Valgis = new List<string>();
                List<string> Kaina = new List<string>();
                int indexPatiekalai = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Valgis.Add(values[0]);
                    Kaina.Add(values[1]);
                }
                foreach (var item in Valgis)
                {
                    Console.Write(item + " ");
                    if (indexPatiekalai < Kaina.Count)
                    {
                        Console.Write(Kaina[indexPatiekalai]);
                    }
                    Console.WriteLine();
                    indexPatiekalai++;
                }
                
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}

