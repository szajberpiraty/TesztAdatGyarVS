using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesztAdatGyar_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Adattoltes adatok = new Adattoltes();
            TesztAdat adat = new TesztAdat(adatok, 0);

            
            Console.WriteLine(adat.VezetekNev);
            Console.ReadLine();
        }
        class Adattoltes
        {
            private Adatlista vezeteknevek = new Adatlista(@"adatok\csaladnevek.txt");
            private Adatlista ferfinevek = new Adatlista(@"adatok\ffi_keresztnevek.txt");
            private Adatlista noinevek = new Adatlista(@"adatok\noi_keresztnevek.txt");
            private Adatlista helysegnevek = new Adatlista(@"adatok\hu_telepulesek.txt");
            
            public string[] VezetekNevek()
            {
                return vezeteknevek.getLista();
            }
            public string Vezeteknev(int i)
            {
                return vezeteknevek.getData(i);
            }

            public string[] FerfiNevek()
            {
                return ferfinevek.getLista();
            }
            public string FerfiNev(int i)
            {
                return ferfinevek.getData(i);
            }

            public string[] NoiNevek()
            {
                return noinevek.getLista();
            }
            public string NoiNev(int i)
            {
                return noinevek.getData(i);
            }
            public string[] HelysegNevek()
            {
                return helysegnevek.getLista();
            }
            public string HelysegNev(int i)
            {
                return helysegnevek.getData(i);
            }


        }
        class TesztAdat
        {
            
            public String VezetekNev { get; set; }
            public String KeresztNev { get; set; }
            public int SzuletesEve { get; set; }
            public string SzuletesiHely { get; set; }
            Random vsz = new Random();


            public TesztAdat(Adattoltes adatok,int nem)
            {
                this.VezetekNev = adatok.Vezeteknev(vsz.Next(0,adatok.VezetekNevek().Length));
                if (nem==0)
                {
                    this.KeresztNev = adatok.FerfiNev(vsz.Next(0,adatok.FerfiNevek().Length));
                }
                else
                {
                    this.KeresztNev = adatok.NoiNev(vsz.Next(0, adatok.NoiNevek().Length));
                }
                this.SzuletesEve = vsz.Next(1920, 2019);
                this.SzuletesiHely = adatok.HelysegNev(vsz.Next(0,adatok.HelysegNevek().Length));


            }
            

        }
        class Adatlista
        {
            private string file;
            private string[] adattomb;

            public Adatlista(string f)
            {
                this.file = f;
                this.adattomb= File.ReadAllLines(Path.Combine(Environment.CurrentDirectory,file), Encoding.Default);
            }
            public string getData(int poz)
            {
                
                return adattomb[poz];
            }
            public string[] getLista()
            {
                return adattomb;
            }
            
        
        }
    }
}
