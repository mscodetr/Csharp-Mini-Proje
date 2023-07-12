// Klavyeden ayrı ayrı girilen saat(0-11) ve dakika(0-59) bilgisine göre akrep ve yelkovanın arasındaki açıyı bulan program

int saat, dakika, aci;

Console.WriteLine("Saat bilgisini giriniz: ");
saat = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Saat bilgisini giriniz: ");
dakika = Convert.ToInt32(Console.ReadLine());


saat = saat * 30;
dakika = dakika * 5;
aci = saat * (dakika / 180);

Console.WriteLine("Akrep ve yelkovanın arasındaki açı: " + aci);
