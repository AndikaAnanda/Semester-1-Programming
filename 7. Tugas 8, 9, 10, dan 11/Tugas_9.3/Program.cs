using System;

namespace Tugas_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hargaBawangPutih = {33000, 32000, 45000, 40000, 37000};
            int[] hargaMinyakGoreng = {30000, 31000, 29000, 27000, 28000};
            int[] hargaGulaPasir = {30000, 40000, 32000, 35000, 37000};

            printArray(hargaBawangPutih, "Bawang Putih");
            printArray(hargaMinyakGoreng, "Minyak Goreng");
            printArray(hargaGulaPasir, "Gula Pasir");
            
            Console.WriteLine("\nHarga maksimal tiap bahan pokok : ");
            hargaMax(hargaBawangPutih, "Bawang Putih");
            hargaMax(hargaMinyakGoreng, "Minyak Goreng");
            hargaMax(hargaGulaPasir, "Gula Pasir");

            Console.WriteLine("\nRata-rata harga tiap bahan pokok : ");
            averageHarga(hargaBawangPutih, "Bawang Putih");
            averageHarga(hargaMinyakGoreng, "Minyak Goreng");
            averageHarga(hargaGulaPasir, "Gula Pasir");

            // INVOKE 3 FUNGSI RETURN :
            Console.WriteLine("Nilai Double : \n");

            Console.WriteLine("\nHarga maksimal tiap bahan pokok : ");
            Console.WriteLine("Bawang Putih : " + hargaMax2(hargaBawangPutih));
            Console.WriteLine("Minyak Goreng : " + hargaMax2(hargaMinyakGoreng));
            Console.WriteLine("Gula Pasir : " + hargaMax2(hargaGulaPasir));

            Console.WriteLine("\nHarga min tiap bahan pokok : ");
            Console.WriteLine("Bawang Putih : " + hargaMin(hargaBawangPutih));
            Console.WriteLine("Minyak Goreng : " + hargaMin(hargaMinyakGoreng));
            Console.WriteLine("Gula Pasir : " + hargaMin(hargaGulaPasir));

            Console.WriteLine("\nRata-rata harga tiap bahan pokok : ");
            Console.WriteLine("Bawang Putih : " + averageHarga2(hargaBawangPutih));
            Console.WriteLine("Minyak Goreng : " + averageHarga2(hargaMinyakGoreng));
            Console.WriteLine("Gula Pasir : " + averageHarga2(hargaGulaPasir));



            
        }
        // FUNGSI VOID
        public static void printArray(int[] harga, string bahan){
            Console.Write("Data harga " + bahan + " : ");
            for (int i = 0; i < harga.Length; i++){
                Console.Write("Rp. " + harga[i] + ", ");
            }
            Console.WriteLine();
        }
        public static void hargaMax(int[] harga, string bahan){
            int hargaMax = harga[0];
            for (int i = 1; i < harga.Length; i++){
                if (harga[i] > hargaMax){
                    hargaMax = harga[i];
                }
            }
            Console.WriteLine("Harga tertinggi dari " + bahan + " adalah : " + hargaMax);
        }
        public static void averageHarga(int[] harga, string bahan){
            int total = 0;
            for (int i = 0; i < harga.Length; i++){
                total += harga[i];
            }
            int averageHarga = total / harga.Length;
            Console.WriteLine("Rata-rata harga dari " + bahan + " adalah : " + averageHarga);
        }
        // FUNGSI RETURN
        public static double hargaMax2(int[] harga){
            int hargaMax = harga[0];
            for (int i = 1; i < harga.Length; i++){
                if (harga[i] > hargaMax){
                    hargaMax = harga[i];
                }
            }
            return hargaMax;
        }
        public static double averageHarga2(int[] harga){
            int total = 0;
            for (int i = 0; i < harga.Length; i++){
                total += harga[i];
            }
            int averageHarga = total / harga.Length;
            return averageHarga;
        }
        public static double hargaMin(int[] harga){
            int min = harga[0];
            for (int i = 1; i < harga.Length; i++){
                if (harga[i] < min){
                    min = harga[i];
                }
            }
            return min;
        }
    }
}
