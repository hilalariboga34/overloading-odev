using System;

class SekilAlanlari
{
    // Karenin alanını hesaplar
    public static double Alan(double kenar)
    {
        return kenar * kenar;
    }

    // Dikdörtgenin alanını hesaplar
    public static double Alan(double uzunKenar, double kisaKenar)
    {
        return uzunKenar * kisaKenar;
    }

    // Dairenin alanını hesaplar
    public static double Alan(double yaricap, bool daire)
    {
        return Math.PI * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Karenin alanı: " + Alan(5)); // 25
        Console.WriteLine("Dikdörtgenin alanı: " + Alan(7, 4)); // 28
        Console.WriteLine("Dairenin alanı: " + Alan(3, true)); // 28.27 (π*3²)
    }
}
