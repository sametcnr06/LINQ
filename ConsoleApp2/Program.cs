//AutoProperty, Object Init., Collection Init.

using ConsoleApp2;

//Object Init
Urun urun = new Urun() { UrunID = 1, UrunAdi = "", Fiyat = 33 };

//Collection Init
List<Urun> urunler = new List<Urun>();
{
    new Urun() { UrunID = 1, UrunAdi = "", Fiyat = 33 };
    new Urun() { UrunID = 1, UrunAdi = "", Fiyat = 33 };
    new Urun() { UrunID = 1, UrunAdi = "", Fiyat = 33 };
}

//5-Anonim tip
var obj = new { ID = 123, Ad = "Cevdet", Soyad = "Korkma" };
