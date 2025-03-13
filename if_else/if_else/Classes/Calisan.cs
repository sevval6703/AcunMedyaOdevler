using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else.Classes
{
    public class Calisan
    {
       public void calisanİsim(string ad,string soyad,string meslek)
        {
            Console.WriteLine("ad:" + ad + " soyad:" + soyad + " meslek:"+meslek);
        }

        
    }
}
/*  Çalışanların Maaş Hesaplaması
Bir çalışan listesi oluşturacağız. Bu listede farklı çalışan türleri olacak:

Genel Müdür (GM)
Müdür (MU)
Programcı (PR)
Stajyer (S)
Her çalışanın maaşı olacak ve toplam maaş hesaplanıp ekrana yazdırılacak.
​​​​​​​Çalışanların Adını, Soyadını, Mesleğini, Maaşını ve Departmanını da ekrana yazdıralım.

Yapılacaklar:

"Calisan" adlı bir sınıf oluşturulacak.
Farklı çalışan türlerinden nesneler oluşturulacak.
Tüm çalışanların maaşları toplanıp ekrana yazdırılacak.*/