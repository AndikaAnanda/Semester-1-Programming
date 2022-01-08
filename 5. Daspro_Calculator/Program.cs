using System;

namespace Daspro_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double inputAwal, inputAkhir, hasil;
                Console.WriteLine("====== Ini adalah kalkulator sederhana =====");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Masukkan angka pertama : ");
                inputAwal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih operator : ");
                Console.WriteLine("1. Penjumlahan ");
                Console.WriteLine("2. Pengurangan ");
                Console.WriteLine("3. Perkalian ");
                Console.WriteLine("4. Pembagian ");
                Console.WriteLine("5. Pangkat 2 ");
                string operasi = Console.ReadLine();
                if (operasi == "5"){
                    Console.WriteLine("Anda menginput " + inputAwal + " ^2");
                    hasil = inputAwal * inputAwal;
                    Console.WriteLine("Hasilnya = " + hasil);
                } else {
                    Console.Write("Masukkan angka kedua : ");
                    inputAkhir = Convert.ToInt32(Console.ReadLine());

                    switch(operasi){
                    case "1":
                    Console.WriteLine("Anda menginput " + inputAwal + " + " + inputAkhir);
                    hasil = inputAwal + inputAkhir;
                    Console.WriteLine("Hasil = " + hasil);
                    break;
                    case "2":
                    Console.WriteLine("Anda menginput " + inputAwal + " - " + inputAkhir);
                    hasil = inputAwal - inputAkhir;
                    Console.WriteLine("Hasil = " + hasil);
                    break;
                    case "3":
                    Console.WriteLine("Anda menginput " + inputAwal + " * " + inputAkhir);
                    hasil = inputAwal * inputAkhir;
                    Console.WriteLine("Hasil = " + hasil);
                    break;
                    case "4":
                    if (inputAkhir == 0){ //karena tipe data double, tidak terjadi divide by zero exception
                        Console.WriteLine("Anda menginput " + inputAwal + " / " + inputAkhir);
                        Console.WriteLine("Angka dibagi dengan 0 = Tidak terdefinisi");
                    } else {
                        Console.WriteLine("Anda menginput " + inputAwal + " / " + inputAkhir);
                        hasil = inputAwal / inputAkhir;
                        Console.WriteLine("Hasil = " + hasil);
                    }
                    break;
                    default:
                    Console.WriteLine("Operator yang anda masukkan tidak valid");
                    break;
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Anda hanya boleh memasukkan angka!!");
            }
            catch (System.DivideByZeroException){
                Console.WriteLine("Angka dibagi dengan 0 = tidak terdefinisi");
            }
        }
    }
}
