namespace Restaurant_CSharp
{
    public class Staliukai
    {
        string ID;
        string vietuSkaicius;
        bool uzimtumas;

        public Staliukai(string _ID, string _vietuSkaicius, bool _uzimtumas)
        {
            Console.WriteLine("Įveskite staliuko ID");
           _ID = Console.ReadLine();
            Console.WriteLine("Įveskite staliuko vietų skaičių");
            _vietuSkaicius = Console.ReadLine();

            ID = _ID;
            vietuSkaicius = _vietuSkaicius;
            uzimtumas = _uzimtumas;
        }
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string VietuSkaicius
        {
            get { return vietuSkaicius; }
            set { vietuSkaicius = value; }
        }
        public bool Uzimtumas
        {
            get { return uzimtumas; }
            set { uzimtumas = value; }
        }
    
        public void StaliukuSarasas()
        {
            List<string> staliukuSarasas = new List<string>();
            /*Console.WriteLine("Įveskite staliuko užimtumą");
           Console.ReadLine(Convert.ToBoolean(uzimtumas));*/
            string[] tables = {
                ID,
                vietuSkaicius
            };
            staliukuSarasas.AddRange(tables);
            Console.WriteLine($"{ID}");
            int ssk = staliukuSarasas.Count;
            Console.WriteLine($"Staliukų yra {ssk}");
        }
    }
}
