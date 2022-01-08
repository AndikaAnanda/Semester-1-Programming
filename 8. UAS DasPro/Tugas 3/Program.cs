using System;

namespace Tugas_3
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();
            Console.Write("Nama depan anda\t\t: ");
            string nama = Console.ReadLine();
            string tahunLahir;
            while (true){
                Console.Write("Tahun kelahiran anda\t: ");
                tahunLahir = Console.ReadLine();
                if (tahunLahir.Length < 4 || tahunLahir.Length > 4){
                    Console.WriteLine("Tahun kelahiran hanya terdiri dari 4 digit angka");
                    continue;
                } else {
                    break;
                }
            }
            DataPemesan pemesan1 = new DataPemesan(nama, tahunLahir);
            Console.WriteLine("Tiket anda\t\t\t:");
            pemesan1.printTiket();
        }
        public static void intro(){
            Console.WriteLine("Selamat datang di program pembuatan tiket bioskop");
            Console.WriteLine("Silakan isi data yang diperlukan untuk pemmbuatan tiket");
            Console.WriteLine();
        }
    }
    class DataPemesan
    {
        string nama;
        string tahunLahir;
        int harga;
        public DataPemesan(string nama, string tahunLahir){
            this.nama = nama;
            this.tahunLahir = tahunLahir;
        }
        public void hitungHarga(){
            if ((2021 - Int32.Parse(tahunLahir)) < 10 || (2021 - Int32.Parse(tahunLahir)) > 60){
                harga = 10000;
                Console.WriteLine("|Harga\t\t: Rp. " + harga + "\t\t|");
            } else if ((2021 - Int32.Parse(tahunLahir)) >= 10 && (2021 - Int32.Parse(tahunLahir)) <= 60){
                harga = 25000;
                Console.WriteLine("|Harga\t\t: Rp. " + harga + "\t\t|");
            }
        }
        public void printTiket(){
            Console.WriteLine("|***************************************|");
            Console.WriteLine("|              -STUDIO 1-               |");
            Console.WriteLine("|Nama\t\t: " + nama + "   \t\t|");
            hitungHarga();
            Console.WriteLine("|***************************************|");
        }
    }
}
