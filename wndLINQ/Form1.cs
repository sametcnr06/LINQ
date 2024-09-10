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

            //LINQ Sorgular�; iki �ekilde yaz�l�r...
            //1-LIKE SQL 
            //2-Expression Tree *********

            //Soru: Fiyata g�re s�ralay�n�z...

            //1.Y�ntem --> LIKE SQL
            //var result = from u in dB.Urunler
            //             orderby u.Fiyat
            //             select u;

            //2.Y�ntem **** --> Expression Tree
            //var result = dB.Urunler.OrderBy(x => x.Fiyat);

            //Soru 2: T�m �r�nleri sadece Ad� ve Fiyat� gelsin...
            //1. var result = from u in dB.Urunler
            //select new {Ad = u.UrunAdi, Fiyat = u.Fiyat};

            //2. var result = dB.Urunler.Select(x => new {ID = x.UrunAdi, Fiyat =x.Fiyat});

            //Soru 3: ID'si 103 olan �r�n� bulunuz ?
            //1. var result = from u in dB.Urunler
            //where u.UrunID == 103
            //select u;

            //2. var result = dB.Urunler.Where(x => x.UrunID == 103); 

            //Soru 4: Fiyat� 200 TL'den k���k olan urunleri desc olarak s�ralay�n�z...
            //1. var result = from u in dB.Urunler
            //where u.Fiyat < 200
            //orderby u.Fiyat descending
            //select u;

            //2. var result =dB.Urunler.Where(x=>x.Fiyat<200).OrderByDescending(x=>x.Fiyat);

            //Soru 5: T�m �r�nleri kategori adlar�yla g�ster?(JOIN)

            //1. var result = from u in dB.Urunler
            //join k in dB.Kategoriler
            //on u.KategoriID equals k.KategoriID
            //select new { u.UrunID, u.UrunAdi, u.Fiyat, k.KategoriAdi };

            //2. var result = dB.Urunler.Join(dB.Kategoriler, x => x.KategoriID, y => y.KategoriID, (x, y) => new { x.UrunID, x.UrunAdi, x.Fiyat, y.KategoriAdi });

            //Soru 6: Kategori ad� ile beraber en pahal� 3 �r�n� listele...

            //1. var result = (from u in dB.Urunler
            //               join k in dB.Kategoriler
            //               on u.KategoriID equals k.KategoriID
            //               orderby u.Fiyat descending
            //               select new { u.UrunID, u.UrunAdi, u.Fiyat, k.KategoriAdi }).Take(3);

            //2. var result = dB.Urunler.Join(dB.Kategoriler, x => x.KategoriID, y => y.KategoriID, (x, y) => new { x.UrunID, x.UrunAdi, x.Fiyat, y.KategoriAdi }).OrderByDescending(x=>x.Fiyat).Take(3);

            //*********************************
            //LINQ => Deffered Mode (Ertelenmi� Y�r�tme) ile �al���r...
            //Sorgu yaz�ld��� yerde de�il, istendi�inde �al���r...
            //Immediate Mode (An�nda Y�r�tme) => ToList(), ToArray()...

            int id = 104;
            var result = (from u in dB.Urunler
                         where u.UrunID == id
                         select u).ToList();

            id = 101;

            dataGridView1.DataSource = result;
        }
    }
}
