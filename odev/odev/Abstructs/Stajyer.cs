using odev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev.Abstructs
{
    public class Stajyer : Calisan,IMaasHesapla
    {
        public override double maasinizNedir()
        {
            return 5000.0;
        }
    }
}
