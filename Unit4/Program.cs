using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Program
    {
        static void Main(string[] args)
        {

            //laczenie lancuchow znakow
            string s1 = "Mam ";
            int Ilosc = 2;
            string s2 = " dzieci";
            string s3 = s1 + Ilosc + s2;

            Console.WriteLine(s3);

            string s4 = string.Format("{0}{1}{2}", s1, Ilosc, s2);
            Console.WriteLine(s4);
        }

     
        
    }
}
