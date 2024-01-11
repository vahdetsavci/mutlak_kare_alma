using System;

namespace mutlak_kare_alma;

class NotPositiveException : Exception
{
    public NotPositiveException() : base("Girdiğiniz sayı pozitif değil!") {}
}