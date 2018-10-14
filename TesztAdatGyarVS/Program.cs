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
            Console.WriteLine(csaladnevek.Length);

            Console.ReadLine();
        }
        class Adatgyar
        {

        }
    }
}
