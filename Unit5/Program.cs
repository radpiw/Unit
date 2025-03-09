using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            Console.WriteLine($"Typ bazowy = {obj}");
            bool bBool = false;
            Console.WriteLine($"Typ boolowski= {bBool}");

            short IShort = 123;
            int iInt = -23;
            long ILong = -1200;
            ushort uUshort = 12;
            ulong iUlong = 1200;

            Console.WriteLine($" Typ całkowity iShort={IShort}, iInt={iInt}, Ilong={ILong}, uuShort={uUshort},IULONG={iUlong}");

            double dDouble = -126.1;
            float fFloat = -10.12345f;
            float fRes = fFloat / 0;

            Console.WriteLine($"dDoble={dDouble}, float={fFloat}");
            Console.WriteLine($"fres={fRes}, czyli ISI={Single.IsInfinity(fRes)}");

            char cZnak = 'A';
            cZnak = (char)65;
            cZnak = '\x0041';

            Console.WriteLine("cZnak={0}", cZnak);
            string lancuchTestowy = "Abcd_12345";
            bool Btest;

            cZnak = lancuchTestowy[0];

            Btest = char.IsLetter(lancuchTestowy, 5);
            Btest = char.IsNumber(lancuchTestowy, 5);
            Btest = char.IsLower(lancuchTestowy, 5);
            Btest = char.IsLetter(lancuchTestowy, 5);
            Btest = char.IsLetterOrDigit(lancuchTestowy, 4);

            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć program....");
            Console.ReadKey();

        }
    }
}
