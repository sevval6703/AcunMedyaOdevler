using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else.Classes
{
    public class YasKategori
    {
        
        public string yasKategori(int yas)
        {
            Console.WriteLine("yasiniz: " + yas);
            if (0 <= yas && yas < 18)
            {
                return "küçüksünüz";
            }
            else if (18 <= yas && yas < 35)
            {
                return "gençsiniz";
            }
            else if (35 <= yas && yas < 55)
            {
                return "yetişkinsiniz";
            }
            else if (55 <= yas && yas < 75)
            {
                return "yaslisiniz";
            }
            else if (75 <= yas && yas < 99)
            {
                return "çok yaslisiniz";
            }
            else
            {
                return "ya hiç doğmadınız ya da çoktan öldünüz";
            }
        }
    }
}
/*  1. Ödev: Yaş Kategorisini Belirleme
Bir kişinin yaşına göre hangi kategoride olduğunu belirleyen bir metod yazacağız.

Eğer kişinin yaşı:

0 ile 18 arasındaysa → "Küçüksünüz"
18 ile 35 arasındaysa → "Gençsiniz"
35 ile 55 arasındaysa → "Yetişkinsiniz"
55 ile 75 arasındaysa → "Yaşlısınız"
75 ile 99 arasındaysa → "Çok yaşlısınız"
0'dan küçük veya 99'dan büyükse → "Ya hiç doğmadınız ya da çoktan öldünüz..."
Bu mesajları string türde döndüren bir metod yazılacak.*/