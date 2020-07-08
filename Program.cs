using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ResponsiUAS
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // Melengkapi kode untuk Menampilkan Menu
            Console.Clear();
            Console.WriteLine("\nPilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Data");
            Console.WriteLine("4. KELUAR\n");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // Melengkapi kode untuk Menambahkan Data Mahasiswa
            Mahasiswa mahasiswa = new Mahasiswa();

            Console.WriteLine("Tambah Data Mahasiswa\n");
            Console.WriteLine("NIM : ");
            mahasiswa.NIM = Console.ReadLine();
            Console.WriteLine("Nama : ");
            mahasiswa.Nama = Console.ReadLine();
            Console.WriteLine("Jenis Kelamin[L/P] : ");
            string JenisKelamin = Console.ReadLine();
            mahasiswa.JenisKelamin = (JenisKelamin == "L" || JenisKelamin == "P") ? "Laki Laki" : "Perempuan";
            Console.WriteLine("IPK : ");
            mahasiswa.IPK = Convert.ToDouble(Console.ReadLine());

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // Melengkapi kode untuk Menghapus Data Mahasiswa
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.WriteLine("NIM : ");
            string nim = Console.ReadLine();

            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.NIM == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("NIM Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // Melengkapi kode untuk Menampilkan Data Mahasiswa
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("NO\tNIM\tNAMA \tJENIS KELAMIN\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}