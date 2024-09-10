using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wndLINQ
{
    internal class UrunDB
    {
        public List<Urun> Urunler => new List<Urun>() {
        new Urun {UrunID =101, UrunAdi="Dec Telefon", Fiyat = 1200, KategoriID = 1 },
        new Urun {UrunID =102, UrunAdi="Satranç Seti", Fiyat = 300, KategoriID = 2 },
        new Urun {UrunID =103, UrunAdi="Tavla", Fiyat = 500, KategoriID = 2 },
        new Urun {UrunID =104, UrunAdi="Defter", Fiyat = 50, KategoriID = 3 },
        new Urun {UrunID =105, UrunAdi="Pergel", Fiyat = 120, KategoriID = 3 },
        };

        public List<Kategori> Kategoriler => new List<Kategori>()
        {
            new Kategori { KategoriID=1, KategoriAdi="Elektronik" },
            new Kategori { KategoriID=2, KategoriAdi="Hobi" },
            new Kategori { KategoriID=3, KategoriAdi="Kırtasiye" }
        };
    }
}
