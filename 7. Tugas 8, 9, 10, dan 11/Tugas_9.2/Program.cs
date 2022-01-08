using System;

namespace Tugas_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();
            while (true){
                Console.Write("Pilihan anda (ketik 0 untuk keluar) : ");
                string pilihan = Console.ReadLine();
                if (pilihan == "1"){
                    defaultBeep();
                } else if (pilihan == "2"){
                    customBeep();
                } else if (pilihan == "0") {
                    break;    
                } else {
                    Console.WriteLine("Input yang anda masukkan salah !");
                }
            }
        }
        public static void defaultBeep(){
            Console.Write("Masukkan jumlah beep yang ingin anda dengar : ");
            int banyakBeep = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < banyakBeep; i++){
                Console.Beep();
            }
        }
        public static void customBeep(){
            Console.Write("Masukkan frekuensi bunyi beep (satuan = Hz) : ");
            int frekuensi = Int32.Parse(Console.ReadLine());
            Console.Write("Masukkan berapa lama bunyi beep yang diinginkan (satuan = milidetik) : ");
            int milisecond = Int32.Parse(Console.ReadLine());
            Console.Beep(frekuensi, milisecond);
        }
        public static void intro(){
            Console.WriteLine("SELAMAT DATANG DI PROGRAM 'BEEP SOUND'");
            Console.WriteLine("======================================");
            Console.WriteLine("Silakan pilih : ");
            Console.WriteLine("1. Bunyi beep berulang kali");
            Console.WriteLine("2. Bunyi beep yang di custom");
        }
    }
}
