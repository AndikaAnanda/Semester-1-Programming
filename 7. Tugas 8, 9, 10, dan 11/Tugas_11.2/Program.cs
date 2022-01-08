using System;
using System.IO;

namespace Tugas_11._2
{
    class Program
    {
        static void Main(string[] args)
        {   
            intro();
            login :
            string namafile = "data_akun.txt";

            Console.WriteLine("Input correct username and password to login!");
            Console.WriteLine("=============================================");
            Console.Write("Username : ");
            string inputUsername = Console.ReadLine() + ", ";
            Console.Write("Password : ");
            string inputPassword = Console.ReadLine() + ".";
            string akun = loginForm(inputUsername, inputPassword);

            if (File.Exists(namafile) == true){
                foreach (string p in File.ReadLines(namafile)){
                    if (p.Contains(akun)){
                        Console.WriteLine("Login successful");
                        Environment.Exit(0);
                    } else {
                        Console.WriteLine("Account is not found");
                        Console.WriteLine("Input 1 to try again or input 0 to exit program\t: ");
                        string action = Console.ReadLine();
                        if (action == "1"){
                            continue;
                        } else if (action == "0"){
                            Environment.Exit(0);
                        }
                    }
                }
            } else {
                Console.WriteLine("You havent sign in yet, please sign up!");
                signInForm(namafile);
            }
            goto login;
        }
        public static void signInForm(string namafile){
            Console.WriteLine("SIGN UP");
            Console.WriteLine("=============================================");
            Console.Write("Username : ");
            string newUsername = Console.ReadLine() + ", ";
            Console.Write("Password : ");
            string newPassword = Console.ReadLine() + ".";
            SignIn newAccount = new SignIn(newUsername, newPassword);
            newAccount.printDetails(namafile);
            Console.WriteLine("Successfully sign up, please login again");
        }
        public static string loginForm(string username, string password){
            string akun = username + password;
            return akun;
        }
        public static void intro(){
            Console.WriteLine("PROGRAM LOGIN SEDERHANA");
            Console.WriteLine("*hanya dapat menerima 1 akun");
            Console.WriteLine("=============================================");
        }

    }
    class SignIn
    {
        string username;
        string password;

        public SignIn(string username, string password){
            this.username = username;
            this.password = password;
        }
        public void printDetails(string filename){
            File.AppendAllText(filename, username);
            File.AppendAllText(filename, password);
        }
    }
}
