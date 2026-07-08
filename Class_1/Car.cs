using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1    
{
    internal class Car: CarDetail      
    {
        public String renk;
        public int hız;
        public double motorhacmi;
        public char durum;
        public int fiyat;
        private int yil;
        private String marka;

        public int YIL {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public String MARKA {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
