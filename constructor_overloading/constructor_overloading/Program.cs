using constructor_overloading.Classees;
using constructor_overloading.Constructor;

Matematik m=new Matematik();

// overloading aynı metot ismi ile farklı paramatrelerde metot tanımlama işlemidir
Console.WriteLine("girdiginiz sayilarin toplami="+ m.topla(5,7));
Console.WriteLine("girdiginiz sayilarin toplami="+ m.topla(2.0, 5.0, 9.0));
Console.WriteLine("girdiginiz sayilarin carpimi="+ m.carpma(8, 7));
Console.WriteLine("girdiginiz sayilarin carpimi="+ m.carpma(3.0, 5.0, 4.0));

Kapi kapi=new Kapi(4);
Kasa kasa=new Kasa("sedan ");
Model model = new Model("X5 ");
Marka marka=new Marka("BMW ");
Pencere pencere=new Pencere(4);
Araba a=new Araba(marka,model,kapi,pencere,kasa);
a.arabaOzellik();


// garbage collector bir sınıftan oluşturulan nesnenin işi bittiğinde bellekte ona ayrılan yeri boşaltır.
// generic class lar derleme zamanı hata kontrolünü sağlarlar.
//generic class avantajları: Kodun daha açık ve anlaşılır olmasını sağlar
//kod tekrarını azaltır. Boxing/Unboxing işlemlerini önleyerek performansı artırır
//Boxing ve Unboxing, değer tiplerinin (value types) referans tiplerine (reference types) dönüştürülmesi ve tersi işlemleridir.
//Boxing:Değer tipinden (int, float, double, struct vs.) referans tipine (object) dönüştürme işlemidir.
//Unboxing:Referans tipinden (object) orijinal değer tipine geri dönüştürme işlemidir.
//Generic yapıları kullanarak esnek programlama yapmak, kodumuzun farklı veri tipleriyle çalışabilmesini sağlar.