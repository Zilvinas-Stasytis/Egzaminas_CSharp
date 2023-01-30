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
using System.Xml.Linq;
using System.Windows.Markup;

namespace Restaurant_CSharp
{
    public class Drinks
    {
        public void Drink()
        {
            StreamReader reader = null;
            if (File.Exists("gerimai.csv"))
            {
                reader = new StreamReader(File.OpenRead("gerimai.csv"));
                List<string> Gerimas = new List<string>();
                List<string> Kaina = new List<string>();
                int indexGerimai = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Gerimas.Add(values[0]);
                    Kaina.Add(values[1]);
                   
                }
               foreach (var item in Gerimas)
                {
                    Console.Write(item + " ");
                    if (indexGerimai < Kaina.Count)
                    {
                        Console.Write(Kaina[indexGerimai]);
                    }
                    Console.WriteLine();
                    indexGerimai++; ;
                }

            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            //Console.ReadLine();
        }
    }
}


