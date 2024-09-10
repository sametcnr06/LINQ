namespace wndLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            //LINQ to Object 
            UrunDB dB = new UrunDB();

            // dataGridView1.DataSource = dB.Urunler;

            //LINQ Sorgularý; iki þekilde yazýlýr...
            //1-LIKE SQL 
            //2-Expression Tree *********

            //Soru: Fiyata göre sýralayýnýz...

            //1.Yöntem --> LIKE SQL
            //var result = from u in dB.Urunler
            //             orderby u.Fiyat
            //             select u;

            //2.Yöntem **** --> Expression Tree
            //var result = dB.Urunler.OrderBy(x => x.Fiyat);

            //Soru 2: Tüm ürünleri sadece Adý ve Fiyatý gelsin...
            //1. var result = from u in dB.Urunler
            //select new {Ad = u.UrunAdi, Fiyat = u.Fiyat};

            //2. var result = dB.Urunler.Select(x => new {ID = x.UrunAdi, Fiyat =x.Fiyat});

            //Soru 3: ID'si 103 olan ürünü bulunuz ?
            //1. var result = from u in dB.Urunler
            //where u.UrunID == 103
            //select u;

            //2. var result = dB.Urunler.Where(x => x.UrunID == 103); 

            //Soru 4: Fiyatý 200 TL'den küçük olan urunleri desc olarak sýralayýnýz...
            //1. var result = from u in dB.Urunler
            //where u.Fiyat < 200
            //orderby u.Fiyat descending
            //select u;

            //2. var result =dB.Urunler.Where(x=>x.Fiyat<200).OrderByDescending(x=>x.Fiyat);

            //Soru 5: Tüm ürünleri kategori adlarýyla göster?(JOIN)

            //1. var result = from u in dB.Urunler
            //join k in dB.Kategoriler
            //on u.KategoriID equals k.KategoriID
            //select new { u.UrunID, u.UrunAdi, u.Fiyat, k.KategoriAdi };

            //2. var result = dB.Urunler.Join(dB.Kategoriler, x => x.KategoriID, y => y.KategoriID, (x, y) => new { x.UrunID, x.UrunAdi, x.Fiyat, y.KategoriAdi });

            //Soru 6: Kategori adý ile beraber en pahalý 3 ürünü listele...

            //1. var result = (from u in dB.Urunler
            //               join k in dB.Kategoriler
            //               on u.KategoriID equals k.KategoriID
            //               orderby u.Fiyat descending
            //               select new { u.UrunID, u.UrunAdi, u.Fiyat, k.KategoriAdi }).Take(3);

            //2. var result = dB.Urunler.Join(dB.Kategoriler, x => x.KategoriID, y => y.KategoriID, (x, y) => new { x.UrunID, x.UrunAdi, x.Fiyat, y.KategoriAdi }).OrderByDescending(x=>x.Fiyat).Take(3);

            //*********************************
            //LINQ => Deffered Mode (Ertelenmiþ Yürütme) ile çalýþýr...
            //Sorgu yazýldýðý yerde deðil, istendiðinde çalýþýr...
            //Immediate Mode (Anýnda Yürütme) => ToList(), ToArray()...

            int id = 104;
            var result = (from u in dB.Urunler
                         where u.UrunID == id
                         select u).ToList();

            id = 101;

            dataGridView1.DataSource = result;
        }
    }
}
