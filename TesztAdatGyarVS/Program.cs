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
        static void Main(string[] args)
        {

            //Path.Combine(Environment.CurrentDirectory, @"adatok\csaladnevek.txt");
            string[] csaladnevek = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\csaladnevek.txt"));

            string[] ferfiak = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\ffi_keresztnevek.txt"));

            string[] nok = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\noi_keresztnevek.txt"));

            string[] helysegek = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"adatok\hu_telepulesek.txt"));




            Console.WriteLine(csaladnevek.Length);

            Console.ReadLine();
        }
        class Adatgyar
        {

        }
    }
}
