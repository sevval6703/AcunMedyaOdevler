using odev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev.Classes
{
    public class Bmw : Car, IOzellik
    {
        public void arabaOzellik(string araba)
        {
            Console.WriteLine(araba + " çok hızlı gider, denizde yüzer, havada uçar");
        }

       
    }
}
