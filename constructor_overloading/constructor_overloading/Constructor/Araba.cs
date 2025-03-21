using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading.Constructor
{
    public class Araba
    {
        public Kapi kapi;
        public Kasa kasa;
        public Model model;
        public Marka marka;
        public Pencere pencere;


        // constructor yapısı.
        public Araba(Marka marka,Model model,Kapi kapi,Pencere pencere,Kasa kasa)
        {
            this.kapi = kapi;
            this.kasa = kasa;
            this.model = model;
            this.marka = marka;
            this.pencere = pencere;
            
        }

        public void arabaOzellik()
        {
            Console.WriteLine("araba markasi:" + marka.markasi +
                "araba modeli:" + model.modeli +
                " kapi sayisi:" + kapi.kapiSayisi +
                " pencere sayisi:" + pencere.pencereSayisi +
                " kasa:" + kasa.kasaTip);
        }
    }
}
