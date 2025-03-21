using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading.Classees
{
    public class Matematik
    {
        public int topla(int x, int y)
        {
            int sonuc=0;
            sonuc = x + y;
            return sonuc;
        }


        public double topla(double x, double y,double z)
        {
            double sonuc=0;
            sonuc = x + y + z;
            return sonuc;
        }

        public int carpma(int x, int y)
        {
            int sonuc=0;
            sonuc = x * y;
            return sonuc;
        }

        public double carpma(double x, double y,double z)
        {
            double sonuc=0;
            sonuc= x * y + y * z;
            return sonuc;
        }
    }
}
