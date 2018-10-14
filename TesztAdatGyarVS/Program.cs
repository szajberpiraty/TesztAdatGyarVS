using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TesztAdatGyarVS
{
    class Program
    {
        public static string[] csaladnevek = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\csaladnevek.txt"),Encoding.Default);

        public static string[] ferfiak = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\ffi_keresztnevek.txt"),Encoding.Default);

        public static string[] nok = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\noi_keresztnevek.txt"),Encoding.Default);

        public static string[] helysegek = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\hu_telepulesek.txt"),Encoding.Default);
        public static Random vsz = new Random();

        static void Main(string[] args)
        {

            //Path.Combine(Environment.CurrentDirectory, @"adatok\csaladnevek.txt");







            List<TesztAdat> tesztadatok = new List<TesztAdat>();

            for (int i = 0; i < 1000; i++)
            {
                TesztAdat tesztadat = new TesztAdat(vsz.Next(0, 2));
                tesztadatok.Add(tesztadat);
            }



            //File.WriteAllLines(@"d:\razgon\tesztadatteszt.txt", tesztadatok.ToArray<TesztAdat>().ToString());

            FileStream file = new FileStream(@"d:\razgon\tesztadatteszt.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(file, Encoding.Default)) { 

                foreach (var tesztadat in tesztadatok)
                    {
                    Console.WriteLine("{0},{1},{2},{3}", tesztadat.VezetekNev, tesztadat.KeresztNev, tesztadat.SzuletesEve, tesztadat.SzuletesiHely);
                    sw.WriteLine(tesztadat.VezetekNev+","+tesztadat.KeresztNev+","+tesztadat.SzuletesEve+","+tesztadat.SzuletesiHely);
                    }
            };


            Console.WriteLine(csaladnevek.Length);

            Console.ReadLine();
        }

        class TesztAdat
        {
            public String VezetekNev { get; set; }
            public String KeresztNev { get; set; }
            public int SzuletesEve { get; set; }
            public string SzuletesiHely { get; set; }

            public TesztAdat(int nem)
            {
                VezetekNev = csaladnevek[vsz.Next(0, csaladnevek.Length)];
                if (nem==0)
                {
                    KeresztNev = ferfiak[vsz.Next(0, ferfiak.Length)];
                }else
                {
                    KeresztNev = nok[vsz.Next(0, nok.Length)];
                }
                
                SzuletesEve = vsz.Next(1920, 2019);
                SzuletesiHely = helysegek[vsz.Next(0, helysegek.Length)];


            }

        }
    }
}

