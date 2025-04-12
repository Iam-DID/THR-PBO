class Program
{
    public static void Main()
    {
        Console.WriteLine("Masukkan jenis karyawan (Tetap/Kontrak/Magang):");
        string jenis = Console.ReadLine();

        Console.WriteLine("Masukkan nama karyawan:");
        string nama = Console.ReadLine();

        Console.WriteLine("Masukkan ID karyawan:");
        string id = Console.ReadLine();

        Console.WriteLine("Masukkan gaji pokok:");
        double gajiPokok = Convert.ToDouble(Console.ReadLine());

        Karyawan karyawan;

        if (jenis.ToLower() == "tetap")
        {
            karyawan = new Karyawan_Tetap(nama, id, gajiPokok);
            Console.WriteLine($"Nama : {karyawan.Nama}");
            Console.WriteLine($"ID Karyawan : {karyawan.ID}");
            Console.WriteLine($"Jenis Karyawan : Karyawan Tetap");
            Console.WriteLine($"Gaji : {karyawan.Hitung_Gaji()}");
        }
        else if (jenis.ToLower() == "kontrak")
        {
            karyawan = new Karyawan_Kontrak(nama, id, gajiPokok);
            Console.WriteLine($"Nama : {karyawan.Nama}");
            Console.WriteLine($"ID Karyawan : {karyawan.ID}");
            Console.WriteLine($"Jenis Karyawan : Karyawan Kontrak");
            Console.WriteLine($"Gaji : {karyawan.Hitung_Gaji()}");
        }
        else if (jenis.ToLower() == "magang")
        {
            karyawan = new Karyawan_Magang(nama, id, gajiPokok);
            Console.WriteLine($"Nama : {karyawan.Nama}");
            Console.WriteLine($"ID Karyawan : {karyawan.ID}");
            Console.WriteLine($"Jenis Karyawan : Karyawan Magang");
            Console.WriteLine($"Gaji : {karyawan.Hitung_Gaji()}");
        }
        else
        {
            Console.WriteLine("Jenis karyawan tidak dikenali.");
        }
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