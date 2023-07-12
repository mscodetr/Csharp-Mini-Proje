// Klavyeden metre cinsiden girilen uzunluğu başka uzunluk birimlerine dönüştüren program

int uzunluk, secim;
Console.WriteLine("Metre cinsi uzunluğu giriniz: ");
uzunluk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dönüştürmek istediğiniz uzunluk birimi numarasınızı giriniz: 1- mm ,2-cm , 3- dm");

while (true)
{
    secim = Convert.ToInt32(Console.ReadLine());
    if (secim >= 1 && secim <= 3)
        break;
    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen 1-3 arasında bir  numara giriniz");
}

if (secim == 1)
{
    uzunluk = uzunluk * 1000;
    Console.WriteLine(" Dönüştürüldü : " + uzunluk + " mm");
}
else if (secim == 2)
{
    uzunluk = uzunluk * 100;
    Console.WriteLine(" Dönüştürüldü : " + uzunluk + " cm");

}
else if (secim == 3)
{
    uzunluk = uzunluk * 10;
    Console.WriteLine(" Dönüştürüldü : " + uzunluk + " dm");
}
