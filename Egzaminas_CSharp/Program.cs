using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Restaurant_CSharp
{
    class Program
    {
        static void Main()
        {
            Choice choose = new Choice();
            Menu Meniu = new Menu();
            Staliukai staleliai = new Staliukai();
            Console.WriteLine(" M            E              N              I             U");
            Console.WriteLine("===========================================================");
            Console.WriteLine("1 - Atidaryti kavinuke");
            Console.WriteLine("2 - Uzdaryti kavinuke");
            Console.WriteLine("===========================================================");
            Console.WriteLine("                                               Pasirinkite ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    staleliai.StaliukuSarasas();
                    choose.tableReservation();
                    break;
                case 2:
                    Console.WriteLine("Kavinuke uzdaryta  :(");
                    break;
            }

        }
    }
}
