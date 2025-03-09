using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5D
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int l1, l2;
            int iloczyn;

            Console.WriteLine("Podaj pierwsza liczbe calkowita:   ");
            line = Console.ReadLine();
            l1 = Convert.ToInt32(line);

            Console.WriteLine("Podaj drugą liczbe calkowitą:    ");
            line = Console.ReadLine();
            l2 = Convert.ToInt32(line);
            iloczyn = l1 * l2;
            Console.WriteLine($"{l1} x {l2} = {iloczyn}");

            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
            Console.ReadKey();

        }
    }
}
