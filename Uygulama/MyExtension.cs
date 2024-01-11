using System;
using System.Collections.Generic;
using System.Linq;

namespace mutlak_kare_alma;

static class MyExtension
{
    internal static bool CevirInt(this string deger, out int sayi)
    {
        sayi = 0;
        try
        {
            sayi = int.Parse(deger);
            return true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Tam sayı olmayan değer girdiniz!");
            return false;
        }
    }

    internal static int[] CevirInt(this string[] strings)
    {
        int[] ints = new int[strings.Length];

        for (int i = 0; i < strings.Length; i++)
        {
            if (CevirInt(strings[i], out int sayi))
                ints[i] = sayi;
            else
                return null;
        }

        return ints;
    }

    internal static List<int> KareAl(this List<int> ints)
    {
        int[] array = new int[ints.Count];

        int num;
        for (int i = 0; i < ints.Count; i++)
        {
            num = ints[i];
            array[i] = num * num;
        }
        return array.ToList();
    }

    internal static List<int> BuyuklerinFarklari(this List<int> ints)
    {
        int[] temp = new int[ints.Count];
        for (int i = 0; i < ints.Count; i++)
        {
            temp[i] = ints[i] - 67;
        }
        return temp.ToList();
    }

    internal static List<int> KucuklerinFarklari(this List<int> ints)
    {
        int[] temp = new int[ints.Count];
        for (int i = 0; i < ints.Count; i++)
        {
            temp[i] = 67 - ints[i];
        }
        return temp.ToList();
    }
}