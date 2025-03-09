using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5B

{
    class Auto
    {
        public string Marka = "Ford";
        private int RokProdukcji = 1999;
        protected int PrzebiegKm = 100000;
    }

    internal class Program
    {


        static void Main(string[] args)
        {

            Auto auto = new Auto();
                
            //Console.WriteLine("Rok produkcji = {0}", auto.RokProdukcji);

            Console.WriteLine("Marka = {0}", auto.Marka);

            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
            Console.ReadKey();

        }
    }
}