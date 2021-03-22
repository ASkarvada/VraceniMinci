using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VraceniMinci
{
    class Program
    {
        static void Main(string[] args)
        {
            int cena = 0;
            int penize = 0;

            while(true)
            {
                Console.Write("Cena kupovaného zboží: ");
                string s1 = Console.ReadLine();
                if (Int32.TryParse(s1, out int result)) cena = result;
                Console.Write("Obnos peněz, kterým platím: ");
                string s2 = Console.ReadLine();
                if (Int32.TryParse(s2, out int result2)) penize = result2;

                if (penize > cena) break;
                else Console.WriteLine("Nemáte dostatek peněz, vyberte si něco jiného, nebo si obstarejte dostatečný obnos.\n");
            }

            int vratit = penize - cena;
            Console.WriteLine($"Vráceno: {vratit} Kč");

            int[] aktualni_mince = new int[] { 50, 20, 10, 5, 2, 1 };
            int padesatikoruny = 0;
            int dvacetikoruny = 0;
            int desetikoruny = 0;
            int petikoruny = 0;
            int dvoukoruny = 0;
            int jednokoruny = 0;

            for (int i = 0; i < aktualni_mince.Length; i++)
            {
                int mince = aktualni_mince[i];
                if(vratit > mince)
                {
                    int pocet_minci = vratit / mince;
                    switch(i)
                    {
                        case 0:
                            padesatikoruny = pocet_minci;
                            break;
                        case 1:
                            dvacetikoruny = pocet_minci;
                            break;
                        case 2:
                            desetikoruny = pocet_minci;
                            break;
                        case 3:
                            petikoruny = pocet_minci;
                            break;
                        case 4:
                            dvoukoruny = pocet_minci;
                            break;
                        case 5:
                            jednokoruny = pocet_minci;
                            break;
                    }
                    vratit -= pocet_minci * aktualni_mince[i];
                }
            }

            Console.WriteLine($@"--------------------------------------
Padesátikoruny: {padesatikoruny}
Dvacetikoruny: {dvacetikoruny}
Desetikoruny: {desetikoruny}
Petikoruny: {petikoruny}
Dvoukoruny: {dvoukoruny}
Jednokoruny: {jednokoruny}");
            Console.ReadLine();
        }
    }
}
