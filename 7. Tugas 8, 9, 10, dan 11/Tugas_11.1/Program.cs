using System;
using System.IO;
namespace contoh
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] angka = File.ReadAllLines("data_decimal.txt");

            Console.WriteLine("Membaca isi file.......");

            float penjumlahan = total();
            Console.WriteLine("Hasil penjumlahan\t= " + penjumlahan);

            nilaiMin(angka);

            nilaiMax(angka);

            rataRata(angka);
            
        }
        public static float total(){
            float total = 0;
            foreach (string p in File.ReadLines("data_decimal.txt")){
                float angka;
                if(float.TryParse(p, out angka)){
                    total += angka;
                }
            }
            return total;
        }
        public static void nilaiMin(string[] angka){
            float min = float.Parse(angka[0]);
            for (int i = 0; i < angka.Length; i++){
                if (float.Parse(angka[i]) < min){
                    min = float.Parse(angka[i]);
                }
            }
            Console.WriteLine("Nilai paling rendah\t= " + min);
        }
        public static void nilaiMax(string[] angka){
            float max = float.Parse(angka[0]);
            for (int i = 0; i < angka.Length; i++){
                if (float.Parse(angka[i]) > max){
                    max = float.Parse(angka[i]);
                }
            }
            Console.WriteLine("Nilai paling tinggi\t= " + max);
        }
        public static void rataRata(string[] angka){
            float rataRata = total() / angka.Length;
            Console.WriteLine("Nilai rata-rata\t\t= " + rataRata);
        }
    }
}
