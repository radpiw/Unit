using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6
{
enum Operacja

    {
        Brak,
        Dodawanie,
        Odejmowanie,
        Mnozenie,
        Dzielenie
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacja op = Operacja.Odejmowanie;
            //reakcja na wartosci typu wyliczyniowego

            switch (op)
            {
                case Operacja.Odejmowanie:
                    Console.WriteLine("Odejmowanie");
                    break;
                case Operacja.Dodawanie:
                    Console.WriteLine("Dodawanie");
                    break;
                case Operacja.Mnozenie:
                    Console.WriteLine("Mnożenie");
                    break;
            }
            //deklaracja tablicy
            int[] ints = new int[7] { 3, 2, 1, 24, 3, 4, 567 };
            Console.WriteLine("przed sortowaniem");

            foreach (int i in ints)
                Console.WriteLine("{0},", i);

            //uzycie tablicy systemowej
            System.Array.Sort(ints);
            System.Array.Reverse(ints);

            Console.WriteLine("Po sortowaniu");
            foreach (int i in ints)
                Console.WriteLine("{0},", i);


            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
            Console.ReadKey();
        }
    }
}
