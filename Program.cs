using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ItalijaHrvatskaStringovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--1. RAZDVAJANJE--");
            String tekst = "Hrvatska ima more";
            String tekst1 = "Italija je prvak svijeta";
            Console.WriteLine(tekst.Substring(0, 8));
            Console.WriteLine(tekst1.Substring(7, 17));

            Console.WriteLine("--2. RAZMAK--");
            Console.WriteLine("Upisite neke znakove");
            string niz = Console.ReadLine();
            Console.WriteLine(niz.Replace(" ", "_"));

            Console.WriteLine("--3. VELIKO MALO SLOVO I OSTALO--");
            Console.WriteLine(" upisite neku rijec");
            Console.WriteLine(" Velika slova " + tekst.ToUpper());
            Console.WriteLine(" Velika slova " + tekst.ToLower());
            Console.WriteLine(tekst1.Substring(0, 3));
            Console.WriteLine(tekst.Substring(tekst.Length - 5, 5));
            Console.WriteLine(tekst.Substring(8 ,4));

            Console.WriteLine("--4. REČENICA--");
            Console.WriteLine("Unesite neku recenicu ");
            string rijec = Console.ReadLine();
            string[] Srijec = rijec.Split(' ');
            Console.WriteLine("Prva rijec je " + Srijec[0]);
            Console.WriteLine("Zadnja rijec je " + Srijec[Srijec.Length - 1 ]);

            Console.WriteLine("--5. ZADATAK BROJEVI--");
            Console.WriteLine("unesite neki broji decimalmn (razdvojiti ih razmakom)");
            string s7 = Console.ReadLine();
            string[] s8 = s7.Split(' ');
            string x = s8[0];
            string y = s8[1];
            Console.WriteLine("vrjednost x = " + x + " vrijednost y = " + y);





            Console.ReadKey();
        }
    }
}
