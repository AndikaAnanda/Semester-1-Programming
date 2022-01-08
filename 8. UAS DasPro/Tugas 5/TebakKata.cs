using System;
using System.Collections.Generic;
namespace Tugas_5
{
    class TebakKata
    {
        string kata;
        int kesempatan;
        public TebakKata(string kata, int kesempatan){
            this.kata = kata;
            this.kesempatan = kesempatan;
        }
        public string cekHuruf(string kata, List<string> hurufTebakan){
            string hurufBenar = "";
            for(int i = 0; i < kata.Length; i++){
                string c = Convert.ToString(kata[i]);
                if(hurufTebakan.Contains(c)){
                    hurufBenar += c;
                } else {
                    hurufBenar += "_";
                }
            }
            return hurufBenar;
        }
        public bool cekKata(string kata, List<string> hurufTebakan){
            bool status = false;
            for(int i = 0; i < kata.Length; i++){
                string c = Convert.ToString(kata[i]);
                if(hurufTebakan.Contains(c)){
                    status = true;
                } else {
                    return status = false;
                }
            }
            return status;
        }
        public void intro(){
            Console.WriteLine("Selamat datang di game \"Hangman\"");
            Console.WriteLine("Misi anda adalah menebak kata yang berhubungan dengan TI UNRI");
            Console.WriteLine("Apabila gagal menebak, maka ilustrasi orang yang sedang gantung diri ditampilkan!!");
            Console.WriteLine("So, Good Luck!!");
            Console.WriteLine("==================================================================================");
        }
    }
}
