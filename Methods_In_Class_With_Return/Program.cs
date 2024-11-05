using Methods_In_Class_With_Return;

islem isl = new islem();

int A, B;

Console.WriteLine("İşlem Seçiniz:" + "\n" + "1- Toplama " + "2- Çıkartma");

int islemsec = Convert.ToInt32(Console.ReadLine());

if (islemsec == 1)
{
    Console.WriteLine("Toplamak istediğiniz sayıları giriniz.");
    A = Convert.ToInt32(Console.ReadLine());
    B = Convert.ToInt32(Console.ReadLine());
    isl.topla(A, B);
}
else if(islemsec == 2)
{
    Console.WriteLine("Çıkartmak istediğiniz sayıları giriniz.");
    A = Convert.ToInt32(Console.ReadLine());
    B = Convert.ToInt32(Console.ReadLine());
    isl.cikart(A, B);
}

Console.Read();