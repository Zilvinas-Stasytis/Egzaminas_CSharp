using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_CSharp
{
    public class Choice
    {
        
        public void tableReservation()
        {
            Staliukai staleliai = new Staliukai();
            Console.WriteLine(" M            E              N              I             U");
            Console.WriteLine("===========================================================");
            Console.WriteLine("1 - Rezervuoti staliuka");
            Console.WriteLine("2 - Iseiti is kavinukes");
            Console.WriteLine("===========================================================");
            Console.WriteLine("                                           Pasirinkite ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    staleliai.StaliukuSarasas();
                    stayingOrAway();
                    break;
                case 2:
                    Console.WriteLine("Jus isejote is kavinukes  :(");
                    break;
            }

        }
        public void stayingOrAway()
        {
            Console.WriteLine(" M            E              N              I             U");
            Console.WriteLine("===========================================================");
            Console.WriteLine("1 - Pasirinkti staliuka");
            Console.WriteLine("2 - Iseiti is kavinukes");
            Console.WriteLine("===========================================================");
            Console.WriteLine("                                               Pasirinkite ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    mealsOrdering();
                    break;
                case 2:
                    Console.WriteLine("Jus isejote is kavinukes  :(");
                    break;
            }
        }
        public void mealsOrdering()
        {
            Meals Valgiai = new Meals();
            Drinks Geriu = new Drinks();
            Console.WriteLine(" M            E              N              I             U");
            Console.WriteLine("===========================================================");
            Console.WriteLine("1 - Uzsisakyti valgius");
            Console.WriteLine("2 - Uzsisakyti gerimus");
            Console.WriteLine("3 - Palikote kavinuke");
            Console.WriteLine("===========================================================");
            Console.WriteLine("                                               Pasirinkite ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Valgiai.Meal();
                    break;
                case 2:
                    Geriu.Drink();
                    break;
                case 3:
                    Console.WriteLine("Gaila,kad nepasilikote ilgiau...");
                    break;
            }


            
        }

    }
}
