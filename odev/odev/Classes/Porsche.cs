﻿using odev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev.Classes
{
    public class Porsche : Car, IOzellik
    {
        public void arabaOzellik(string araba)
        {
            Console.WriteLine(araba + "  havada uçar");
        }

       
    }
}
