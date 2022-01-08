using System;

namespace Tugas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();
            Console.Write("Rate mata uang USD --> Rupiah\t: ");
            double rate = Double.Parse(Console.ReadLine());
            Console.Write("Jumlah USD yg ingin di convert\t: ");
            double USD = Double.Parse(Console.ReadLine());
            Console.WriteLine("====================================");
            Console.WriteLine("Hasil konversi\t\t\t: " + hasilKonversi(rate, USD));
        }
        public static double hasilKonversi(double rate, double USD){
            double hasil = rate * USD;
            return hasil;
        }
        public static void intro(){
            Console.WriteLine("Selamat datang di program konversi mata uang (USD --> Rupiah)");
        }
    }
}
