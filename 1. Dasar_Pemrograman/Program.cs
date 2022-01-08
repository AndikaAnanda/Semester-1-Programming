// menambahkan file dari sistem
using System; 

namespace Dasar_Pemrograman
{
    class Program
    {
        static void intro(int level) {
            // menampilkan teks pada terminal
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Level : " + level);
        }

        static bool MulaiMain(int level) {
            
            intro(level);

            // mendeklarasikan dan assignment variabel
            Random rng = new Random();
            int codeA = rng.Next(level);
            int codeB = rng.Next(level);
            int codeC = rng.Next(level);


            // proses aritmatika
            int hasilTambah = codeA + codeB + codeC;
            int hasilKali = codeA * codeB * codeC;

            Console.WriteLine("- Password terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya = " + hasilKali);
            Console.WriteLine("");
            Console.Write("Enter Code A: ");
            string tebakanA = Console.ReadLine();
            Console.Write("Enter Code B: ");
            string tebakanB = Console.ReadLine();
            Console.Write("Enter Code C: ");
            string tebakanC = Console.ReadLine();

            // int hasilTambahTebakan = Convert.ToInt32(tebakanA) + Convert.ToInt32(tebakanB) + Convert.ToInt32(tebakanC);
            // int hasilKaliTebakan = Convert.ToInt32(tebakanA) * Convert.ToInt32(tebakanB) * Convert.ToInt32(tebakanC);

            int tebakA = Convert.ToInt32(tebakanA);
            int tebakB = Convert.ToInt32(tebakanB);
            int tebakC = Convert.ToInt32(tebakanC);

            Console.WriteLine("Tebakan anda adalah : "+tebakanA+" "+tebakanB+" "+tebakanC+" !");
            // Console.WriteLine("Hasil tambah tebakan anda : " + hasilTambahTebakan);
            // Console.WriteLine("Hasil kali tebakan anda : " + hasilKaliTebakan);

            if(tebakA == codeA && tebakB == codeB && tebakC == codeC) {
                Console.WriteLine("Tebakan anda benar!!");
                return true;
            } else {
                Console.WriteLine("Tebakan anda salah!!");
                return false;
            }
        }

        // main method --> pintu utama masuk program
        static void Main(string[] args) 
        {   
            int level = 1;
            int maxLevel = 5;
            while (level <= maxLevel){
                bool bGameOver = MulaiMain(level);
                if (bGameOver) {
                    level++;
            }
            Console.WriteLine("Selamat, anda telah menyelesaikan game!");
           }
        }
    }
}
