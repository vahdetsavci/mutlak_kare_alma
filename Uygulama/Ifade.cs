using System;

namespace mutlak_kare_alma;

enum Baslik
{
    Yildiz,
    Cizgi
}

static class Ifade
{
    static string[] ifadeler;

    static Ifade()
    {
        ifadeler = new string[]
        {
            "************************************",
            "------------------------------------"
        };
    }

    internal static void Yazdir(Baslik talep)
    {
        Console.WriteLine(ifadeler[(int)talep]);
    }

    internal static void Yazdir(string mesaj)
    {
        Yazdir(Baslik.Yildiz);
        Console.WriteLine(mesaj);
        Yazdir(Baslik.Cizgi);
    }
}