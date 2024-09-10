using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal static class Genisletme
    {
        public static int KareAL(this int sayi)
        {
            return sayi * sayi;
        }

        public static int KupAl(this int sayi)
        {
            return sayi * sayi * sayi;
        }

        public static int IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }

        public static int Bol(this int sayi, int bolum)
        {
            return sayi / bolum;
        }

        public static string Eko(this string str, int adet)
        {
            string s = "";
            for (int i = 0; i < adet; i++)
            {
                s += str;
            }
            return s;
        }
    }
}
