using System;

namespace Tugas_9._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            intro();
            
            int panjangArray = Int32.Parse(Console.ReadLine());
            double[] angka = new double[panjangArray];

            for (int i = 0; i < angka.Length; i++){
                Console.Write("Masukkan angka yang ingin dibulatkan (Format desimal = , / koma): ");
                angka[i] = Double.Parse(Console.ReadLine());
            }
            
            printInputUser(angka);

            Console.WriteLine();
           
            printHasilPembulatan(angka);
        }
        public static void printInputUser(double[] arrayAngka){
            Console.Write("Angka yang akan diproses : ");
            foreach (double j in arrayAngka){
                Console.Write(j + ", ");
            }
        }
        public static void printHasilPembulatan(double[] arrayAngka){
            Console.Write("Angka yang telah dibulatkan : ");
            foreach (double j in arrayAngka){
                if (Math.Ceiling(j) == -0){
                    Console.WriteLine(j + "--> " + 0);
                } else {
                    Console.WriteLine(j + " --> " + Math.Ceiling(j) + ", ");
                }
            }
        }
        public static void intro(){
            Console.WriteLine("SELAMAT DATANG DI PROGRAM PEMBULATAN ANGKA DENGAN METODE CEILING");
            Console.WriteLine("================================================================");
            Console.Write("Masukkan banyak angka yang akan di proses : ");
        }
    }
}
