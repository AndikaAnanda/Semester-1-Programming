using System;
using System.IO;
using System.Collections.Generic;
namespace Tugas_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // membaca isi "file.txt"
            string[] kataTersedia = File.ReadAllLines("kata.txt");

            // memilih salah satu kata pada file secara acak
            Random rnd = new Random();
            int angkaRandom = rnd.Next(0, 13);
            string kata = kataTersedia[angkaRandom];
            int kesempatan = 8;

            List<string> hurufTebakan = new List<string>{};
    
            TebakKata tebakKata = new TebakKata(kata, kesempatan);
            tebakKata.intro();
            string userInput;
            while(true){
                Console.Write("Tebakan\t: ");
                userInput = Console.ReadLine();
                hurufTebakan.Add(userInput);

                if(tebakKata.cekKata(kata, hurufTebakan)){
                    Console.Clear();
                    Console.WriteLine("Selamat, anda berhasil menyelesaikan permainan!");
                    break;
                } else if(kata.Contains(userInput)){
                    Console.Clear();
                    Console.WriteLine("Tebakan benar!");
                    Console.WriteLine(tebakKata.cekHuruf(kata, hurufTebakan));
                } else {
                    Console.Clear();
                    Console.WriteLine("Tebakan salah");
                    kesempatan -= 1;
                    Console.WriteLine(tebakKata.cekHuruf(kata, hurufTebakan));
                    
                }
                if(kesempatan == 0){
                    Console.WriteLine("_________________________");
                    Console.WriteLine("  |/                   | ");
                    Console.WriteLine("  |                   ( )");
                    Console.WriteLine(@"  |                   /|\");
                    Console.WriteLine("  |                    | ");
                    Console.WriteLine(@"  |                   / \");
                    Console.WriteLine("__|__                    ");
                    Console.WriteLine("Game over....");
                    Console.WriteLine("Silakan mencoba kembali");
                    break;
                } else if(kesempatan == 7){
                    Console.WriteLine();
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    Console.WriteLine();
                } else if(kesempatan == 6){
                    Console.WriteLine();
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    Console.WriteLine();
                } else if(kesempatan == 5){
                    Console.WriteLine("_____");
                    Console.WriteLine("  |/ ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    Console.WriteLine();
                } else if(kesempatan == 4){
                    Console.WriteLine("_____________");
                    Console.WriteLine("  |/                     ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("__|__                    ");
                    Console.WriteLine();
                } else if(kesempatan == 3){
                    Console.WriteLine("_________________________");
                    Console.WriteLine("  |/                     ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("__|__                    ");
                    Console.WriteLine();
                } else if(kesempatan == 2){
                    Console.WriteLine("_________________________");
                    Console.WriteLine("  |/                   | ");
                    Console.WriteLine("  |                   ( )");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("__|__                    ");
                    Console.WriteLine();
                } else if(kesempatan == 1){
                    Console.WriteLine("_________________________");
                    Console.WriteLine("  |/                   | ");
                    Console.WriteLine("  |                   ( )");
                    Console.WriteLine(@"  |                   /|\");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("  |                      ");
                    Console.WriteLine("__|__                    ");
                    Console.WriteLine();
                }
            }
        }
    }
}
