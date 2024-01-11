using System;
using System.Collections.Generic;
using System.Linq;

namespace mutlak_kare_alma;

class BL // Business Layer (İş Katmanı)
{
    Sayi sayi;
    List<int> kucukler, buyukler;

    internal BL()
    {
        sayi = new Sayi();
    }

    internal List<int> VeriTopla()
    {
        Baslangic:
        int n = sayi.AdetBelirle();
        if (n > 0)
        {
            SayiAl:
            int[] ints = sayi.SayiAl(n);
            if (ints != null)
                return ints.ToList();
            else
                Console.WriteLine("Değerler okunamadı!");
            goto SayiAl;
        }

        goto Baslangic;
    }

    internal void Duzenle(List<int> ints)
    {
        ints = ints.FindAll(I => I != 67);
        kucukler = ints.FindAll(I => I < 67);
        buyukler = ints.FindAll(I => I > 67);
    }

    internal void Yazdir()
    {
        Console.WriteLine();
        Console.WriteLine("67'den küçük sayıların 67 ile olan farklarının toplamı \n (sayı 1 - 67) + (sayı 2 - 67) + ... + (x + y)^2 = n");
        Ifade.Yazdir(Baslik.Cizgi);
        Console.WriteLine(sayi.Topla(kucukler.KucuklerinFarklari()));

        Console.WriteLine("67'den büyük sayıların 67 ile olan farklarının kareleri toplamı \n (sayı 1 - 67)^2 + (sayı 2 - 67)^2 + ... + (x + y)^2 = n");
        Ifade.Yazdir(Baslik.Cizgi);
        Console.WriteLine(sayi.Topla(buyukler.BuyuklerinFarklari().KareAl()));
    }
}