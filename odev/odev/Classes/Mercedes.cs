using odev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev.Classes
{
    public class Mercedes : Car, IOzellik
    {
        public void arabaOzellik(string araba)
        {
            Console.WriteLine(araba + " denizde yüzer, havada uçar");

        }

       
    }
}
