using System;

namespace Tugas_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrayDosen = new string[30, 2] {
                {"Ery Safrianti, ST., MT.\t\t", "197402242000032000"},
                {"Noveri Iysberri M,ST., M.Sc\t", "197402242000032000"},
                {"Suwitno, ST., MT.\t\t", "196611021999031000"},
                {"Dr. Azriyenni, ST., M.Eng\t", "197304011999032000"},
                {"Budhi Anto, ST., MT.\t\t", "197208132000121000"},
                {"Feranita, ST., MT.\t\t", "197302012005012000"},
                {"Linna Oktaviana Sari, ST., MT.\t", "197910152006042000"},
                {"Dr. Indra Yasri, ST., MT.\t", "197403072002121000"},
                {"Dr. Yusnita Rahayu,ST., M.Eng\t", "197511042005012000"},
                {"Dr. Fri Murdiya, MT.\t\t", "198002052003121000"},
                {"Dr. Iswadi HR, ST., MT.\t\t", "197807152003121000"},
                {"Dr. Feri Candra, MT.\t\t", "197404282002121000"},
                {"Dr. Dahliyusmanto, S.Kom., M.Sc\t", "197204222006041000"},
                {"Dr. Anhar, ST., MT\t\t", "197604092002121000"},
                {"Dr. Ir. Antonius Rajagukguk, MT\t", "196607311997021000"},
                {"Nurhalim, ST., MT\t\t", "197408202002121000"},
                {"Dian Yayan Sukma, ST., MT\t", "197803082003121000"},
                {"Eddy Hamdani, ST., MT\t\t", "196709081999031000"},
                {"Rahyul Amri, ST., MT\t\t", "196707231999031000"},
                {"Amir Hamzah, ST., MT\t\t", "197507052002121000"},
                {"Ir. Edy Ervianto, MT\t\t", "196412151997021000"},
                {"Firdaus, ST., MT\t\t", "197705102005011000"},
                {"Salhazan Nasution, MIT\t\t", "198611112009121000"},
                {"Dr. Dewi Nasien, M.Sc\t\t", "000000000000000000"},
                {"Rahmat Rizal Andhi, ST., MT\t", "198312032019031000"},
                {"Irsan Taufik Ali, ST., MT\t", "198005102005011000"},
                {"Dr. Febrizal, ST., MT\t\t", "197802222002121000"},
                {"Edi Susilo, S.Pd.,M.Kom.,M.Eng\t", "199110292019031000"},
                {"T. Yudi Handiwandra, M.Kom\t", "197207122000121000"},
                {"Dian Ramadhani, ST., MT\t\t", "198805052020122000"},
            };

            intro();
            while (true){
                Console.Write("Pilihan anda (tekan 0 untuk keluar): ");
                string pilihan = Console.ReadLine();
                if (pilihan == "1"){
                    printAll(arrayDosen);
                } else if (pilihan == "2"){
                    printDosenTI(arrayDosen);
                } else if (pilihan == "3"){
                    printUnder45(arrayDosen);
                } else if(pilihan == "0"){
                    break;
                } else {
                    Console.WriteLine("Input yang anda masukkan salah!");
                }
            }

            
        }
        public static void printAll(string[,] array2D){
            Console.WriteLine("DATA DOSEN JTE UNIVERSITAS RIAU");
            Console.WriteLine("===============================");
            Console.WriteLine("No.\t" + "Nama Dosen\t\t\t" + "NIP");
            for (int row = 0; row < 30; row++){
                Console.Write(row + 1 + ".\t");
                for (int column = 0; column < 2; column++){
                    string res = array2D[row, column];
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }
        public static void printDosenTI(string[,] array2D){
            Console.WriteLine("DATA DOSEN JTE PRODI TI UNIVERSITAS RIAU");
            Console.WriteLine("========================================");
            Console.WriteLine("No.\t" + "Nama Dosen\t\t\t" + "NIP");
            for (int row = 0; row < 30; row++){
                Console.Write(row + 1 + ".\t");
                for (int column = 0; column < 2; column++){
                    if (row < 11){
                        continue;
                    }
                    string res = array2D[row, column];
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }
        public static void printUnder45(string[,] array2D){
            Console.WriteLine("DATA DOSEN JTE YANG BERUSIA DIBAWAH 45 UNIVERSITAS RIAU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("No.\t" + "Nama Dosen\t\t\t" + "NIP");
            for (int row = 0; row < 30; row++){
                Console.Write(row + 1 + ".\t");
                for (int column = 0; column < 2; column++){
                    int tahun = Int32.Parse(array2D[row, 1].Substring(0, 4));
                    if (tahun < 1976){
                        continue;
                    }
                    string res = array2D[row, column];
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public static void intro(){
            Console.WriteLine("SELAMAT DATANG DI PROGRAM DATA DOSEN JTE UNIVERSITAS RIAU!");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Silakan pilih : ");
            Console.WriteLine("1. Data seluruh Dosen JTE");
            Console.WriteLine("2. Data Dosen JTE prodi Teknik Informatika");
            Console.WriteLine("3. Data Dosen JTE yang berusia dibawah 45 tahun");
        }
    }
}

