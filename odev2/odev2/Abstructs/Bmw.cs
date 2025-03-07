using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Abstructs
{
    public class Bmw : OrtakOzellik,IHesapla
    {
        public void hesapla(string tur, int saat)
        {
            if (tur == "Bmw")
            {
                Console.WriteLine("tüketilen yakit:" + 80 * saat);
            }
        }

        public override double ortakOzellik()
        {
            return 80.0;
        }
    }
}
