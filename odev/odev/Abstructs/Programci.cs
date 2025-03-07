using odev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev.Abstructs
{
    public class Programci : Calisan,IMaasHesapla
    {
        public override double maasinizNedir()
        {
            return 40000.0;
        }
    }
}
