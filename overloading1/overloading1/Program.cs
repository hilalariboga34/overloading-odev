using System;

class MatematikselIslemler
{
    // İki tam sayıyı toplar
    public static int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayıyı toplar
    public static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Bir dizideki tüm tam sayıları toplar
    public static int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("İki sayının toplamı: " + Topla(3, 5)); // 8
        Console.WriteLine("Üç sayının toplamı: " + Topla(3, 5, 7)); // 15
        Console.WriteLine("Dizi elemanlarının toplamı: " + Topla(new int[] { 1, 2, 3, 4 })); // 10
    }
}
