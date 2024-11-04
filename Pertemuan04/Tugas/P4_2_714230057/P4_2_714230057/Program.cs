using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230057
{
    // Kelas abstrak MenuItem
    abstract class MenuItem
    {
        // Menggunakan enkapsulasi untuk atribut (private fields)
        private string nama;
        private int harga;
        private string deskripsi;

        // Constructor untuk inisialisasi atribut
        public MenuItem(string nama, int harga, string deskripsi)
        {
            this.nama = nama;
            this.harga = harga;
            this.deskripsi = deskripsi;
        }

        // Getter untuk nama
        public string Nama
        {
            get { return nama; }
        }

        // Getter untuk harga
        public int Harga
        {
            get { return harga; }
        }

        // Getter untuk deskripsi
        public string Deskripsi
        {
            get { return deskripsi; }
        }

        // Metode abstrak untuk menampilkan deskripsi (akan di-override)
        public abstract string TampilkanDeskripsi();
    }

    // Kelas Makanan yang diwariskan dari MenuItem
    class Makanan : MenuItem
    {
        public Makanan(string nama, int harga, string deskripsi) : base(nama, harga, deskripsi) { }

        public override string TampilkanDeskripsi()
        {
            return $"Makanan: {Nama}, Rp{Harga} - {Deskripsi}. Cocok sebagai hidangan utama.";
        }
    }

    // Kelas Minuman yang diwariskan dari MenuItem
    class Minuman : MenuItem
    {
        public Minuman(string nama, int harga, string deskripsi) : base(nama, harga, deskripsi) { }

        public override string TampilkanDeskripsi()
        {
            return $"Minuman: {Nama}, Rp{Harga} - {Deskripsi}. Segarkan hari Anda!";
        }
    }

    // Kelas Dessert yang diwariskan dari MenuItem
    class Dessert : MenuItem
    {
        public Dessert(string nama, int harga, string deskripsi) : base(nama, harga, deskripsi) { }

        public override string TampilkanDeskripsi()
        {
            return $"Dessert: {Nama}, Rp{Harga} - {Deskripsi}. Manis dan enak!";
        }
    }

    // Program utama
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek dari kelas turunan dengan input dari pengguna
            Console.WriteLine("Masukkan detail makanan:");
            Console.Write("Nama Makanan: ");
            string namaMakanan = Console.ReadLine();
            Console.Write("Harga Makanan: ");
            int hargaMakanan = int.Parse(Console.ReadLine());
            Console.Write("Deskripsi Makanan: ");
            string deskripsiMakanan = Console.ReadLine();
            Makanan makanan1 = new Makanan(namaMakanan, hargaMakanan, deskripsiMakanan);

            Console.WriteLine("\nMasukkan detail minuman:");
            Console.Write("Nama Minuman: ");
            string namaMinuman = Console.ReadLine();
            Console.Write("Harga Minuman: ");
            int hargaMinuman = int.Parse(Console.ReadLine());
            Console.Write("Deskripsi Minuman: ");
            string deskripsiMinuman = Console.ReadLine();
            Minuman minuman1 = new Minuman(namaMinuman, hargaMinuman, deskripsiMinuman);

            Console.WriteLine("\nMasukkan detail dessert:");
            Console.Write("Nama Dessert: ");
            string namaDessert = Console.ReadLine();
            Console.Write("Harga Dessert: ");
            int hargaDessert = int.Parse(Console.ReadLine());
            Console.Write("Deskripsi Dessert: ");
            string deskripsiDessert = Console.ReadLine();
            Dessert dessert1 = new Dessert(namaDessert, hargaDessert, deskripsiDessert);

            // Menampilkan deskripsi untuk setiap item
            Console.WriteLine("\nDeskripsi Item Menu:");
            Console.WriteLine(makanan1.TampilkanDeskripsi());
            Console.WriteLine(minuman1.TampilkanDeskripsi());
            Console.WriteLine(dessert1.TampilkanDeskripsi());
        }
    }
}
