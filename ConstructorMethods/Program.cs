using ConstructorMethods;

string ad, soyad, mslk;
int yasi;

Console.WriteLine("Ad - Soyad - Meslek - Yaş giriniz.");

ad = Console.ReadLine();
soyad = Console.ReadLine();
mslk = Console.ReadLine();
yasi = Convert.ToInt32(Console.ReadLine());

Bilgi blg = new Bilgi(ad,soyad,mslk,yasi);

Console.Read();