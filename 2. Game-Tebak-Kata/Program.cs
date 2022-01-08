using System;
using System.Collections.Generic;
namespace Game_Tebak_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            // saya butuh variabel untuk kata rahasianya
            // saya butuh jumlah nyawa
            // saya butuh list untuk mnyimpan huruf-huruf yang diinput user
            // saya butuh intro
            // saya butuh loop untuk berapa kali permainan dimainkan
            // saya butuh logic untuk membandingkan kata rahasia dengan huruf dalam list
            // saya butuh boolean untuk menentukan menang atau kalah

            string kata = "pemrograman";
            int kesempatan = 5;
            List<string> hurufTebakan = new List<string> {};

            Console.WriteLine("Selamat Bermain Tebak Kata!");
            Console.WriteLine($"Kata ini terdiri dari {kata.Length} huruf");
            Console.WriteLine($"Anda memiliki {kesempatan} kali kesempatan");

            
            string userInput;
            while(true){
                Console.Write("Tebakan : ");
                userInput = Console.ReadLine();
                hurufTebakan.Add(userInput);

                if(cekKata(kata, hurufTebakan)){
                    Console.WriteLine("Selamat, anda berhasil!");
                    break;
                } else if(kata.Contains(userInput)){
                    Console.WriteLine("Tebakan anda benar!");
                    Console.WriteLine(cekHuruf(kata, hurufTebakan));
                } else {
                    Console.WriteLine("Huruf tidak ditemukan dalam kata rahasia!");
                    kesempatan = kesempatan - 1;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan} kali lagi!");
                }
                if(kesempatan == 0){
                    Console.WriteLine($"Game over, kata yang benar adalah {kata}");
                    Console.WriteLine("Bye bye....");
                    break;
                }
            }
        }
        static bool cekKata(string kata, List<string> hurufTebakan)
        {   bool status = false;
            int i = 0;
            while(i < kata.Length){
                string c = Convert.ToString(kata[i]);
                if(hurufTebakan.Contains(c)){
                    status = true;
                } else {
                    return status = false;
                }
                i++;
            }
            return status;
        }

        static string cekHuruf(string kata, List<string> hurufTebakan)
        {
            string hurufBenar = "";
            int i = 0;
            while(i < kata.Length){
                string c = Convert.ToString(kata[i]);
                if(hurufTebakan.Contains(c)){
                    hurufBenar = hurufBenar + c;
                }else{
                    hurufBenar = hurufBenar + "_";
                }
                i++;
            }
            return hurufBenar;
        }
    }
}
