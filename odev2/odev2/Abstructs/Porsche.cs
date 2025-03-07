using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Abstructs
{
    public class Porsche : OrtakOzellik,IHesapla
    {
        public void hesapla(string tur, int saat)
        {
            if (tur == "Porsche")
            {
                Console.WriteLine("tüketilen yakit:" + 60 * saat);
            }
        }

        public override double ortakOzellik()
        {
            return 60.0;
        }
    }
}
