using System;

class ZamanFarkiHesaplama
{
    // Gün cinsinden farkı hesaplar
    public static int ZamanFarki(DateTime tarih1, DateTime tarih2)
    {
        return (int)(tarih2 - tarih1).TotalDays;
    }

    // Saat cinsinden farkı hesaplar
    public static int ZamanFarki(DateTime tarih1, DateTime tarih2, bool saat)
    {
        return (int)(tarih2 - tarih1).TotalHours;
    }

    // Yıl, ay ve gün cinsinden farkı hesaplar
    public static (int yil, int ay, int gun) ZamanFarki(DateTime tarih1, DateTime tarih2, string format)
    {
        int yilFarki = tarih2.Year - tarih1.Year;
        int ayFarki = tarih2.Month - tarih1.Month;
        int gunFarki = tarih2.Day - tarih1.Day;

        if (gunFarki < 0)
        {
            ayFarki--;
            gunFarki += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
        }

        if (ayFarki < 0)
        {
            yilFarki--;
            ayFarki += 12;
        }

        return (yilFarki, ayFarki, gunFarki);
    }

    static void Main(string[] args)
    {
        DateTime tarih1 = new DateTime(2020, 1, 1);
        DateTime tarih2 = DateTime.Now;

        Console.WriteLine("Gün farkı: " + ZamanFarki(tarih1, tarih2)); // Gün farkı
        Console.WriteLine("Saat farkı: " + ZamanFarki(tarih1, tarih2, true)); // Saat farkı
        var (yil, ay, gun) = ZamanFarki(tarih1, tarih2, "format");
        Console.WriteLine($"Yıl: {yil}, Ay: {ay}, Gün: {gun}"); // Yıl:Ay:Gün
    }
}
