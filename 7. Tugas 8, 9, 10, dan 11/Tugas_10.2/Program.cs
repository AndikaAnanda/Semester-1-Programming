using System;

namespace Tugas_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            string konsentrasi;
            int umur;
            double IPK;

            MahasiswaDetails[] mahasiswa = new MahasiswaDetails[10];
            for (int i = 0; i < mahasiswa.Length; i++){
                Console.Write("Detail Mahasiswa " + (i + 1) + "\nInput nama\t\t: ");
                nama = Console.ReadLine();
                Console.Write("Input konsentrasi\t: ");
                konsentrasi = Console.ReadLine();
                Console.Write("Input umur\t\t: ");
                umur = Int32.Parse(Console.ReadLine());
                Console.Write("Input IPK\t\t: ");
                IPK = Double.Parse(Console.ReadLine());

                mahasiswa[i] = new MahasiswaDetails(nama, konsentrasi, umur, IPK);
            }
            Console.Clear();
            for (int i = 0; i < mahasiswa.Length; i++){
                Console.WriteLine("Data Mahasiswa " + (i + 1));
                mahasiswa[i].printDetails();
            }
        }
    }
    class MahasiswaDetails
    {
        string nama;
        string konsentrasi;
        int umur;
        double IPK;

        public MahasiswaDetails(string nama, string konsentrasi, int umur, double IPK){
            this.nama = nama;
            this.konsentrasi = konsentrasi;
            this.umur = umur;
            this.IPK = IPK;
        }
        public void printDetails(){
            Console.WriteLine("Nama\t\t: " + nama);
            Console.WriteLine("Konsentrasi\t: " + konsentrasi);
            Console.WriteLine("Umur\t\t: " + umur);
            Console.WriteLine("IPK\t\t: " + IPK);
            Console.WriteLine("=============================");
        }
    }
}
