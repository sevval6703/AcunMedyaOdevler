using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else.Classes
{
    public class ArabaYakit
    {
       public void markaYakitTuketimi(string marka, int tuketim)
        {
            Console.WriteLine("araba markası " + marka + " yakit tüketimi: " + tuketim);
        }

    }
}
/* Arabaların Benzin Tüketimi
Bir araba listesi oluşturacağız. Bu listede farklı arabalar olacak ve her birinin benzin tüketimi hesaplanacak.

Yapılacaklar:

"Araba" adlı bir sınıf oluşturulacak.
Farklı arabalar için nesneler oluşturulacak.
Tüm arabaların toplam benzin tüketimi hesaplanıp ekrana yazdırılacak.*/