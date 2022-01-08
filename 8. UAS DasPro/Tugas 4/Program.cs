using System;
using System.Text;
namespace Tugas_4
{
    class Program
    {
        static void Main(string[] args)
        {
            intro();

            Console.Write("Kata\t: "); // input user
            string kata = Console.ReadLine();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(kata); // mengubah input user menjadi nilai ASCII
            
            generatePassword(asciiBytes); // proses modifikasi nilai ASCII

            char[] hasilKata = Encoding.ASCII.GetChars(asciiBytes); // mengubah nilai ASCII yang telah dimodifikasi menjadi karakter kembali

            printHasil(hasilKata); // menampilkan hasil
        }
        public static void intro(){
            Console.WriteLine("Selamat datang di program \"Password Generator\"");
            Console.WriteLine("Silakan input kata yang akan dienkripsi menjadi password");
            Console.WriteLine("Tidak boleh menginput angka dan simbol!");
            Console.WriteLine("====================================================");
        }
        public static void generatePassword(byte[] arrayKata){
            for (int i = 0; i < arrayKata.Length; i++){
                if (arrayKata[i] == 32){
                    arrayKata[i] = 32;
                } else if(arrayKata[i] == 88){ // mengubah X --> A
                    arrayKata[i] = 65;
                } else if(arrayKata[i] == 89){ // mengubah Y --> B
                    arrayKata[i] = 66;
                } else if(arrayKata[i] == 90){ // mengubah Z --> C
                    arrayKata[i] = 67;
                } else if(arrayKata[i] == 120){ // mengubah x --> a
                    arrayKata[i] = 97;
                } else if(arrayKata[i] == 121){ // mengubah y --> b
                    arrayKata[i] = 98;
                } else if(arrayKata[i] == 122){ // mengubah z --? c
                    arrayKata[i] = 99;
                } else if((arrayKata[i] > 32 && arrayKata[i] < 65) || (arrayKata[i] > 90 && arrayKata[i] < 97) || (arrayKata[i] > 123 && arrayKata[i] < 126)){
                    // kondisi apabila user menginput selain kata
                    Console.WriteLine("Anda tidak boleh menginput angka dan karakter!");
                    Environment.Exit(0);
                } else {
                    arrayKata[i] += 3; // menambah nilai ASCII menjadi 3
                }
            }
        }
        public static void printHasil(char[] kata){
            Console.Write("Hasil\t: ");
            for (int i = 0; i < kata.Length; i++){
                Console.Write(kata[i]);
            }
        }
    }
}
