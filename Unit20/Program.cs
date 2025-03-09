using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit20
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ul. Kaliskiego 12a";
            bool bFoundDigit = false;

            foreach (char znak in text)
            {
                bFoundDigit = char.IsDigit(znak);
                if (bFoundDigit)
                    break;
            }

            Console.WriteLine("Znalazł = {0}", bFoundDigit);


        }
    }
}
