using System;
using System.IO;

namespace Tugas_11._2_prototype
{
    class Program
    {
        static void Main(string[] args)
        {   
            login :
            while(true){
                Console.Write("Input your username\t: ");
                string usernameLogin = Console.ReadLine() + ".txt";
                Console.Write("Input your password\t: ");
                string passwordLogin = Console.ReadLine() + ".txt";
                if (File.Exists(usernameLogin) == true && File.Exists(passwordLogin) == true){
                    Console.WriteLine("Login successful");
                    Environment.Exit(0);
                } else {
                    Console.WriteLine("Account is not found");
                    Console.WriteLine("Input 1 to try again");
                    Console.Write("Input 2 to sign in : ");
                    string action = Console.ReadLine();
                    if (action == "1"){
                        continue;
                    } else if (action == "2"){
                        break;
                    }
                }
            }

            Console.WriteLine("Fill username and password to create new account!");
            Console.Write("New Username\t: ");
            string usernameNew = Console.ReadLine() + ".txt";
            Console.Write("New Password\t: ");
            string passwordNew = Console.ReadLine() + ".txt";
            Console.Clear();
            printDetails(usernameNew);
            printDetails(passwordNew);
            goto login;

        }
        public static void printDetails(string filename){
            File.AppendAllText(filename, ".");
        }
    }
}
