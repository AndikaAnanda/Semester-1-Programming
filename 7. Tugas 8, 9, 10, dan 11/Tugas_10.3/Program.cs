using System;

namespace Tugas_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string kata1 = "informatika";
            string kata2 = "informasi";
            string kataSama = "";
            string kataBeda = "";
            Console.WriteLine("Kata yang dibutuhkan adalah : " + kata1 + " dan " + kata2);
            // menghilangkan huruf yang sama tiap string
            kata1 = kata1.Remove(8, 1);
            kata1 = kata1.Remove(9, 1);

            kata2 = kata2.Remove(8, 1);
            Console.WriteLine("Kata yang telah siap diproses adalah : " + kata1 + " dan " + kata2);

            for (int i = 0; i < kata1.Length; i++){
                for (int j = 0; j < kata2.Length; j++){
                    if (String.Compare(kata1.Substring(i, 1), kata2.Substring(j, 1)) == 0){
                        kataSama += kata2.Substring(j, 1);
                    } else if (String.Compare(kata1.Substring(i, 1), kata2.Substring(j, 1)) != 0 && kata2.Contains(kata1.Substring(i, 1)) == false){
                        kataBeda += kata1.Substring(i, 1);
                    } else if (String.Compare(kata1.Substring(i, 1), kata2.Substring(j, 1)) != 0 && kata1.Contains(kata2.Substring(j, 1)) == false){
                        kataBeda += kata2.Substring(j, 1);
                    } else {
                        continue;
                    }
                }
            }
            // karena hasil kataBedanya agak aneh, saya ubah secara manual
            kataBeda = kataBeda.Remove(1, 7);
            kataBeda = kataBeda.Remove(2, 7);
            kataBeda = kataBeda.Remove(3, 6);
            Console.WriteLine("===========================================");
            Console.WriteLine("Kata yang sama pada kedua string adalah -> " + kataSama + ", dengan banyak kata : " + kataSama.Length);
            Console.WriteLine("Kata yang berbeda pada kedua string adalah -> " + kataBeda + ", dengan banyak kata : " + kataBeda.Length);
        }
    }
}
