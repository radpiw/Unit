using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            if ((args !=null) && (args.Length>0))
                    {
                Console.WriteLine("Zadana zostala {0}-elementowa tablica parametrow wejsc", args.Length);
                foreach (string  arg in args)

                {
                    Console.WriteLine(arg);
                }
            }
            else Console.WriteLine("brak parametrow wejsc");
            int l1 = 10;
            double l2 = 1.2;
            char c = 'a';

            Console.WriteLine("To są liczby l1={0} l2={1} c={2}", l1, l2, c);
            Console.WriteLine("To są liczby l1={l1} l2={l2} c={c}");

            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
            Console.ReadKey();
        }
    }
}
