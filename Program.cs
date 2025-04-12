class Program
{
    public static void Main()
    {

        Karyawan_Tetap karyawan1 = new Karyawan_Tetap("Syadid","1",500000);
        Console.WriteLine(karyawan1.Hitung_Gaji());
        Karyawan_Kontrak karyawan2 = new Karyawan_Kontrak("Budiono", "2", 500000);
        Console.WriteLine(karyawan2.Hitung_Gaji());
        Karyawan_Magang karyawan3 = new Karyawan_Magang("Siregar", "3", 500000);
        Console.WriteLine(karyawan3.Hitung_Gaji());
    }
}

class Karyawan
{
    private string nama;
    private string id;
    private double gaji_pokok;
    public Karyawan(string nama, string id, double gaji_pokok)
    {
        this.nama = nama;
        this.id = id;
        this.gaji_pokok = gaji_pokok;
    }

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }
    public string ID
    {
        get { return id; }
        set { id = value; }
    }
    public double Gaji_Pokok
    {
        get { return gaji_pokok; }
        set { gaji_pokok = value; }
    }
    public virtual double Hitung_Gaji()
    {
        return gaji_pokok;
    }
}
class Karyawan_Tetap : Karyawan
{
    private double bonus_tetap = 500000 ;

    public Karyawan_Tetap(string nama, string id, double gaji_Pokok) : base(nama,id,gaji_Pokok)
    {
    }
    public override double Hitung_Gaji()
    {
        return Gaji_Pokok + bonus_tetap;
    }
}
class Karyawan_Kontrak : Karyawan
{
    private double Potongan_kontrak = 200000;
    public Karyawan_Kontrak(string nama, string id, double gaji_Pokok) : base(nama, id, gaji_Pokok)
    {
    }
    public override double Hitung_Gaji()
    {
        return Gaji_Pokok - Potongan_kontrak;
    }
}
class Karyawan_Magang : Karyawan
{
    public Karyawan_Magang(string nama, string id, double gaji_Pokok) : base(nama, id, gaji_Pokok)
    {
    }
    public override double Hitung_Gaji()
    {
        return base.Hitung_Gaji();
    }
}