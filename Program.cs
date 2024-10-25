using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemelyazonosito
{
    internal class Program
    {
        public static void SzemSzam()
        {
            Console.WriteLine("Kérem adja meg a szemszam első 10 jegyét: ");
            var szemszam = Console.ReadLine();
            string szuletes = szemszam.Substring(7, 3);
            int ev = DateTime.Now.Year;


            if (szemszam[0] % 2 == 0)
            {
                Console.WriteLine("A személy férfi");
            }
            else Console.WriteLine("A személy nő");

            Console.WriteLine($"A születési sorszám: {szuletes}");


            int szulev = 1900 + int.Parse(szemszam.Substring(1, 2));
            if (szemszam[0] == '3' || szemszam[0] == '4')
            {
                szulev += 100;
            }

            int szulinap = ev - szulev;
            Console.WriteLine("A {0} szülinapját ünnepli.", szulinap);
        }
            static void Main(string[] args)
            {
                SzemSzam();
            }
        }
    }

