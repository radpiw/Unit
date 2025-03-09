using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst i nacisnij klawicz ENTER..");
            //Console.Write("..");

            string line = Console.ReadLine();
            Console.WriteLine(line);

            if (string.IsNullOrEmpty(line))
                Console.WriteLine("Nie podales zadnego tekstu");
            else
            {

                int iLiczba;
                iLiczba = Convert.ToInt32(line);
                Console.WriteLine("Podałeś {0}", line);
                Console.WriteLine("Liczba = {0}", iLiczba);
                Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
                Console.ReadKey();


            }


        }
    }
}
