using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit20A
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ul.Kaliskiego 12a";
            bool bFoundDigit;

            if (!string.IsNullOrEmpty(text))
            {
                int iLength = text.Length;
                int iIndex = 0;

                do
                {
                    bFoundDigit = char.IsDigit(text[iIndex]);
                    iIndex++;
                }
                while (!bFoundDigit && (iIndex < iLength));
            }
            else
                bFoundDigit = false;
            Console.WriteLine("Znalazł={0}", bFoundDigit);
        }
    }
}
