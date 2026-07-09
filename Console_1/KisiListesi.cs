using System;
using System.Collections.Generic;
using System.Text;

namespace Console_1
{
    internal class KisiListesi
    {
        public void kisilistele(string ad)
        {
            for(int i=0; i<10; i++) {
                Console.WriteLine(i + " - " + ad);
            }
        }
    }
}
