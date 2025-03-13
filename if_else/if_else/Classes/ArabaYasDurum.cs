using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else.Classes
{
    public class ArabaYasDurum
    {
        public string arabaYasi(int yasi)
        {
            Console.WriteLine("araba yasi:" + yasi);
            if(0<=yasi && yasi<10)
            {
                return "arabaniz yeni";
            }
            else if(10<=yasi && yasi < 20)
            {
                return "servise götürmeniz gerekebilir";
            }
            else if(20<=yasi && yasi<30)
            {
                return "arabaniz hurdaya çikabilir.";
            }
            else
            {
                return "ya hiç üretilmedi ya da trafikten men edilmiştir.";
            }

        }

    }
}

/* 2. Ödev: Araba Yaşı ve Durumu
Bir arabanın yaşına göre hangi durumda olduğunu belirleyen bir metod yazacağız.

Eğer arabanın yaşı:

0 ile 10 arasındaysa → "Arabanız yeni"
10 ile 20 arasındaysa → "Servise götürmeniz gerekebilir"
20 ile 30 arasındaysa → "Arabanız hurdaya çıkabilir"
0'dan küçük veya 30'dan büyükse → "Ya hiç üretilmedi ya da trafikten men edilmiştir"
Bu mesajları döndüren string türde bir metod yazılacak.

Ekstra araştırma konusu: Bu işlem switch-case ile nasıl yapılabilir?*/