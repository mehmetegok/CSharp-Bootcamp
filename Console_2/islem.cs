using System;
using System.Collections.Generic;
using System.Text;

namespace Console_2
{
    internal class islem
    {
        public int topla(int a, int b)
        {
            int sonuc = a + b;
            Console.WriteLine("Sonuç:" + sonuc);
            return sonuc;
        }

        public int kare(int deger)
        {
            int karesonucu = deger * deger;
            Console.WriteLine("Sonuç:" + karesonucu);
            return karesonucu;
        }
    }

}
