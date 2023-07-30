static void KacinciKelime(int sayfasayisi, int sayfa)
{

    int satir, cevap;
    char secim;
    Console.WriteLine("Merak ediyorum! Acaba kaçıncı kelimedesin? Öğrenmek ister misin? (e/h)");
    secim = Convert.ToChar(Console.ReadLine());
    if (secim == 'e')
    {
        Console.WriteLine("Buna sevindim :) Şimdi bana kaçıncı satırda olduğunu söyler misin?");
        satir = Convert.ToInt32(Console.ReadLine());
        int kelime = (sayfasayisi * 120);
        int kacincikelime = sayfa * 120 / satir;
        Console.WriteLine(sayfasayisi + " Sayfalık toplam " + kelime + " tane kelime bulunan kitabında " + sayfa + " . sayfasında {0} ", kacincikelime + ". kelimedesin. Keyifli okumalar :)");
    }
    else { Console.WriteLine("Bunu duyduğuma üzüldüm! Belki başka zamana :("); }



    Console.WriteLine("Hadi sana bir sayfa söyleyeyim ilk kelimenin kaçıncı kelime olduğunu bilmeye çalış! :)");
    Random random = new Random();

    int sayi = random.Next(2, sayfasayisi);
    int kelimede = sayfa * 120;
    Console.WriteLine("İşte sayfa sayısı bu:" + sayi);
    Console.WriteLine("Cevabını girebilir misin? : ");

    cevap = Convert.ToInt32(Console.ReadLine());

    while (true)
    {
        if (cevap < kelimede)
        {
            Console.WriteLine("Biraz yukarı çıkmalısın! Cevap: "+ kelimede);;
        }
        else if (cevap > kelimede)
        {
            Console.WriteLine("Biraz aşağı inmelisin! Cevap: "+ kelimede);
            cevap = Convert.ToInt32(Console.ReadLine());
        }
        else Console.WriteLine("Tebrikler bildin! :) Cevap : " + kelimede);
        break;
    }

}
KacinciKelime(100, 20);

