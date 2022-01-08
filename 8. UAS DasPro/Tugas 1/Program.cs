using System;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();
            Console.Write("Masukkan nama depan\t: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan NIM\t\t: ");
            string NIM = Console.ReadLine();
            Console.WriteLine("Pilihan konsentrasi\t: ");
            Console.WriteLine("1. RPL");
            Console.WriteLine("2. KCV");
            Console.WriteLine("3. Jaringan");
            Console.Write("Pilihan anda\t\t: ");
            string konsentrasi = Console.ReadLine();
            switch (konsentrasi){
                case "1" :
                konsentrasi = "RPL     ";
                break;
                case "2" :
                konsentrasi = "KCV     ";
                break;
                case "3" :
                konsentrasi = "Jaringan";
                break;
                default:
                Console.WriteLine("Input yang anda masukkan salah!");
                break;
            }
            Mahasiswa mahasiswa1 = new Mahasiswa(nama, NIM, konsentrasi);
            Console.WriteLine("Name tag anda : ");
            mahasiswa1.printNameTag();
            
        }
        public static void intro(){
            Console.WriteLine("Selamat datang di program pembuatan Name Tag untuk Mahasiswa Baru UNRI");
            Console.WriteLine("Silakan isi data diri anda!");
        }
    }
    class Mahasiswa
    {
        string nama;
        string NIM;
        string konsentrasi;
        public Mahasiswa(string nama, string NIM, string konsentrasi){
            this.nama = nama;
            this.NIM = NIM;
            this.konsentrasi = konsentrasi;
        }
        public void printNameTag(){
            Console.WriteLine("|***************************************|");
            Console.WriteLine("|Nama\t\t: " + nama + "   \t\t|");
            Console.WriteLine("|NIM\t\t: " + NIM + "\t\t|");
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("|Konsentrasi\t: " + konsentrasi + "\t\t|");
            Console.WriteLine("|***************************************|");
        }
    }
}
