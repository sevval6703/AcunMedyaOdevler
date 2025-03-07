using odev2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.Abstructs
{
    public class Mercedes : OrtakOzellik,IHesapla
    {
        public void hesapla(string tur, int saat)
        {
            if (tur == "Mercedes")
            {
                Console.WriteLine("tüketilen yakit:" + 70 * saat);
            }
        }

        public override double ortakOzellik()
        {
            return 70.0;
        }
    }
}
