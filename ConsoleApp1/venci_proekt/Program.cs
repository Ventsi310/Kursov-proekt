using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venci_proekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zavedenie koeto vuvejda:
            // izbor na masa-pu6a4i,ne pu6a4i 
            // broi posetiteli
            //izbor na hrana- salata, osnovno, deserti
            //izbor na pitie- alkohol, bezalkoholno-fre6,gazirano,ha6 dve o  ,toplo
            //pla6tane-ke6, bankomatna karta

            Console.WriteLine("broi?-");
            int a = int.Parse(Console.ReadLine());
            int broi= 0;
            Console.WriteLine("pu6a4i ili ne pu6a4i?-");
            string masa = Console.ReadLine();

            string[] salata= new string[a];
            string[] osnovno= new string[a];
            string[] desert= new string[a];
            Console.WriteLine("izberi hrana");
            for (int i = 0; i < a; i++)
            {
                broi++;
                Console.Write($"Salati{broi}-");
                salata[i] = Console.ReadLine();
                Console.Write($"Osnovno {broi} -");
                osnovno[i] = Console.ReadLine();
                Console.Write($"Deserti{broi}-");
                desert[i] = Console.ReadLine();
            }
            broi = 0;
            string[] napitka= new string[a];
            for (int i = 0; i < a; i++)
            {
                broi++;
                Console.Write($"Napitka {broi}- ");
                napitka[i] = Console.ReadLine();
            }
        }
    }
}
