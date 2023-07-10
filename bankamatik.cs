static void Banka()
{
    int cekilecek;
    int bakiye = 45678;
    string mno;
    Console.WriteLine("Merhaba hoşgeldiniz! Lütfen müşteri numaranızı giriniz: ");
    mno = Console.ReadLine();
    if (mno.Length == 8)
    {
        int islemturu;
        Console.WriteLine(mno + " No'lu müşterimiz lütfen yapacağınız işlem numarasını giriniz: 1- Para Yatırma, 2- Para Çekme, 3-Bakiye Sorgulama");
        islemturu = Convert.ToInt32(Console.ReadLine());
        if (islemturu == 1)
        {
            Console.WriteLine(mno + " No'lu müşterimiz lütfen yatırmak istediğiniz miktarı giriniz: ");
            int para = Convert.ToInt32(Console.ReadLine());
            bakiye = para + bakiye;
            Console.WriteLine(para+" TL yatırılmıştır. Güncel bakiyeniz: " + bakiye);
        }
        else if (islemturu == 2)
        {
            Console.WriteLine(mno + " No'lu müşterimiz lütfen çekmek istediğiniz miktarı giriniz: ");
            cekilecek = Convert.ToInt32(Console.ReadLine());
            bakiye = bakiye - cekilecek;
            Console.WriteLine(cekilecek + "TL çekilmiştir. Güncel bakiyeniz: " + bakiye);
        }
        else
        {
            Console.WriteLine(mno + "No'lu müşterimiz güncel bakiyeniz: " + bakiye);
        }
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir müşteri numarası giriniz: ");
    }
}


Banka();
