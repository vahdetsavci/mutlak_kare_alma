using System;
using System.Collections.Generic;

namespace mutlak_kare_alma;

class Sayi
{
    internal int AdetBelirle()
    {
        Baslangic:
        Ifade.Yazdir("Sayı adetini giriniz!");
        if (Console.ReadLine().CevirInt(out int n) && n > 0)
            return n;
        else if (n < 1)
            Console.WriteLine("Pozitif olmayan değer girdiniz!");
        
            goto Baslangic;
    }

    internal int[] SayiAl(int sayiAdet)
    {
        Console.WriteLine($"Arada boşluk olacak şekilde {sayiAdet} sayı giriniz!");
        Ifade.Yazdir(Baslik.Cizgi);
        string[] strings = Console.ReadLine().Split(' ');

        if (strings.Length == sayiAdet)
            return strings.CevirInt();
        else
            return null;
    }

    internal List<int> BuyukBul(List<int> ints, out List<int> kucukler)
    {
        List<int> buyukler = new(); kucukler = new();
        foreach (int num in ints)
        {
            if (num > 67)
                buyukler.Add(num);
            else
                kucukler.Add(num);
        }
        return buyukler;
    }

    internal int Topla(List<int> ints)
    {
        int sum = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            sum += ints[i];
        }
        return sum;
    }
}