try
{
    Console.Write("Lütfen 1. sayıyı giriniz : "); // kullanıcan 1. sayıyı girmesini istiyoruz.
    int sayi = Convert.ToInt32(Console.ReadLine());

    Console.Write("Lütfen 2. sayıyı giriniz : "); // kullanıcan 2. sayıyı girmesini istiyoruz.
    int sayi2 = Convert.ToInt32(Console.ReadLine());
}

catch (FormatException) //FortmatException diyerek bir dizeyi dönüştürmeye çalışırken hatalı giriş kullanıldığında.
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz."); // hatayı döndürüyoruz 
}