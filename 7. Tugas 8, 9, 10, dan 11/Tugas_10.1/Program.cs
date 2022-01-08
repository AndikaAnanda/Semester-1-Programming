using System;

namespace Tugas_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Mahasiswa pertama=====");
            Mahasiswa mahasiswa1 = new Mahasiswa();
            Console.WriteLine("Nama mahasiswa\t: " + mahasiswa1.Nama);
            Console.WriteLine("NIM \t\t: " + mahasiswa1.NIM);
            Console.WriteLine("konsentrasi \t: " + mahasiswa1.konsentrasi);
            Console.WriteLine("IPK \t\t: " + mahasiswa1.IPK);
            mahasiswa1.kelulusan();
            Console.WriteLine();

            Console.WriteLine("=====Mahasiswa kedua : =====");
            Mahasiswa mahasiswa2 = new Mahasiswa("Nesya Putri Maharani", 12345678, "Web Development", 3.8f, true);
            Console.WriteLine("Nama mahasiswa\t: " + mahasiswa2.Nama);
            Console.WriteLine("NIM \t\t: " + mahasiswa2.NIM);
            Console.WriteLine("konsentrasi \t: " + mahasiswa2.konsentrasi);
            Console.WriteLine("IPK \t\t: " + mahasiswa2.IPK);
            mahasiswa2.kelulusan();
            Console.WriteLine();

            Console.WriteLine("=====Mahasiswa ketiga : =====");
            Mahasiswa mahasiswa3 = new Mahasiswa("Wafi Tsabitul", 123425478);
            Console.WriteLine("Nama mahasiswa\t: " + mahasiswa3.Nama);
            Console.WriteLine("NIM \t\t: " + mahasiswa3.NIM);
            Console.WriteLine("konsentrasi \t: " + mahasiswa3.konsentrasi);
            Console.WriteLine("IPK \t\t: " + mahasiswa3.IPK);
            mahasiswa3.kelulusan();
            Console.WriteLine();

            Console.WriteLine("=====Mahasiswa keempat : =====");
            Mahasiswa mahasiswa4 = new Mahasiswa("Salwa Nabilah", 123425478, 1.4f, false);
            Console.WriteLine("Nama mahasiswa\t: " + mahasiswa4.Nama);
            Console.WriteLine("NIM \t\t: " + mahasiswa4.NIM);
            Console.WriteLine("konsentrasi \t: " + mahasiswa4.konsentrasi);
            Console.WriteLine("IPK \t\t: " + mahasiswa4.IPK);
            mahasiswa4.kelulusan();
            Console.WriteLine();
        }
    }
    class Mahasiswa
    {
        public string Nama;
        public int NIM;
        public string konsentrasi;
        public float IPK;
        public bool statusLulus;

        public Mahasiswa(){
            Nama = "Andika Ananda";
            NIM = 2107135917;
            konsentrasi = "Cloud Computing";
            IPK = 3.9f;
            statusLulus = true;
        }
        public Mahasiswa(string Nama, int NIM, string konsentrasi, float IPK, bool statusLulus){
            this.Nama = Nama;
            this.NIM = NIM;
            this.konsentrasi = konsentrasi;
            this.IPK = IPK;
            this.statusLulus = statusLulus;
        }
        public Mahasiswa(string Nama, int NIM){
            this.Nama = Nama;
            this.NIM = NIM;
            this.konsentrasi = "Cloud Computing";
            this.IPK = 3.9f;
            this.statusLulus = true;
        }
        public Mahasiswa(string Nama, int NIM, float IPK, bool statusLulus){
            this.Nama = Nama;
            this.NIM = NIM;
            this.konsentrasi = "Mobile app development";
            this.IPK = IPK;
            this.statusLulus = statusLulus;
        }
        public void kelulusan(){
            if (statusLulus == true){
                Console.WriteLine("Status kelulusan: Lulus");
            } else {
                Console.WriteLine("Status kelulusan: Tidak Lulus");
            }
        }
    }
}
