namespace mutlak_kare_alma;

class PL // Presentation Layer (Sunum Katmanı)
{
    BL calis = new BL();

    internal PL()
    {
        calis.Duzenle(calis.VeriTopla());
        calis.Yazdir();
    }
}