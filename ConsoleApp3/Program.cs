//Extension Methods, Expression Tree(İfade Ağacı)
//1-Static bir sınıf yaz..
//2-Static sınıf içine static metod yaz...
//3-Metodun ilk parametresinde this keyword'u ile hangi yapıya o metot eklenecek ise belirtilir...

using ConsoleApp3;

int sayi = 12;
string mesaj = "Merhaba ";

Console.WriteLine(sayi.KareAL());
Console.WriteLine(mesaj.Eko(3));

//Expression Tree(İfade Ağacı) 

Console.WriteLine(sayi.Bol(3).KareAL().IkiyeBol().KupAl());

List<int> sayilar = new List<int>() {7, 54, 9, 456, 6, 1, };
foreach (var item in sayilar.FindAll(x => x % 2 == 1))
    Console.WriteLine(item);
