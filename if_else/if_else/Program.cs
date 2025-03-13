using if_else.Classes;


// yas kategorisinin belirlenmesi sorusunun cevabı
YasKategori y=new YasKategori();
string sonuc = y.yasKategori(21);
Console.WriteLine(sonuc);

//araba yas ve durum sorusunun cevabı
ArabaYasDurum a=new ArabaYasDurum();
string sonuc1 = a.arabaYasi(9);
Console.WriteLine(sonuc1);

//arabaların benzin tüketimi sorusu
Bmw b=new Bmw();
b.markaYakitTuketimi("bmw", 100);

Mercedes m = new Mercedes();
m.markaYakitTuketimi("mercedes", 250);

Porsche p = new Porsche();
p.markaYakitTuketimi("porsche", 300);


//çalışanların maaş hesaplaması
GenelMudur gm=new GenelMudur();
gm.calisanİsim("şevval", "polat", "genel müdür");


Mudur mu=new Mudur();
mu.calisanİsim("sinem", "polat", "müdür");


Programci pr=new Programci();
pr.calisanİsim("nazan", "polat", "programcı");


Stajyer st=new Stajyer();
st.calisanİsim("ishak", "polat", "stajyer");




