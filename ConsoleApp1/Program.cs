Console.WriteLine("LINQ");
//LINQ:Languqge Integrated Query

//C# LINQ için gelen yenilikler...
//1-var
//2-Auto Property
//3-Object Init.
//4-Collection Init.
//5-Anonymous Object(Tyoe)
//6-Extension Methods
//7-Expression Tree
//8-Lambda Expression

//Gerçekte var diye bir tip yok...
//Değişkenin tipi ilk değer atandığında belli olur...
//daha sonrada değiştirelemez...

var d1 = 23;
var d2 = "Cevdet";
var d3 = 'A';
var d4 = new List<int>();
var d5 = 33.44;
var d6 = 123L;
var d7 = 11.90M;
var d8 = true;

//d1 = "selami";

//C# 4.0 => Dynamic
//Dynamic; her tipi kabul eder...

dynamic d9 = "Merhaba";
d9 = true;

object obj = 12;
dynamic dyn = 12;   
int sayi1, sayi2;

sayi1 = (int)obj;
sayi2 = dyn;


