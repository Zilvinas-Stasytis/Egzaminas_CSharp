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
using System.Security.Cryptography;
using System.Collections.Immutable;
using System.Collections;
using System.Runtime.ExceptionServices;

namespace Restaurant_CSharp
{
    public class Staliukai
    {
        public int[] Id = new int[] { };
        public int[] VietuSkaicius = new int[] { };
        public bool[] Uzimtumas = new bool[] { };
        public int[] ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public int[] vietuSkaicius
        {
            get { return VietuSkaicius; }
            set { VietuSkaicius = value; }
        }
        public bool[] uzimtumas
        {
            get { return Uzimtumas; }
            set { Uzimtumas = value; }
        }
        public void StaliukuSarasas()
        {

            int linesCount = 0;
            StreamReader reader = null;
            if (File.Exists("staliukai.csv"))
            {
                /*Staliukai[] Staleliai = new string[,,] { };*/
                List<string> ID = new List<string>();
                List<string> vietuSkaicius = new List<string>();
                List<string> uzimtumas = new List<string>();
                reader = new StreamReader(File.OpenRead("staliukai.csv"));

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    ID.Add(values[0]);
                    vietuSkaicius.Add(values[1]);
                    uzimtumas.Add(values[2]);

                }
                foreach (var item in ID)
                {
                    Console.Write(item, "");
                }
                foreach (var item in vietuSkaicius)
                {
                    Console.Write(item, "");
                }
                foreach (var item in uzimtumas)
                {
                    Console.Write(item);

                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("File doesn't exist");
            }

        }

    }
}








