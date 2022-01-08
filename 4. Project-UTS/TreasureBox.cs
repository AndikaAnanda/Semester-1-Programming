using System;
using System.Collections.Generic;
namespace Project_UTS
{
    class TreasureBox
    {
        public TreasureBox()
        {

            string kata = "1379";
            int kesempatan = 5;
            List<string> hurufTebakan = new List<string> {};

            
            Console.WriteLine("The gate to sea cave is blocked by a security clam,");
            Console.WriteLine("To enter the sea cave, you have to guess how many times megalodon eats in a week, so the clam will open");
            Console.WriteLine($"The number is consist of {kata.Length} number");
            Console.WriteLine($"You just have {kesempatan} chance");

            
            string userInput;
            while(true){
                Console.Write("Tebakan : ");
                userInput = Console.ReadLine();
                hurufTebakan.Add(userInput);

                if(cekKata(kata, hurufTebakan)){
                    Console.WriteLine("Congrats, you did it");
                    Console.Write("The correct answer is " + kata);
                    break;
                } else if(kata.Contains(userInput)){
                    Console.WriteLine("Your guess is right");
                    Console.WriteLine(cekHuruf(kata, hurufTebakan));
                } else {
                    Console.WriteLine("The number is not found");
                    kesempatan = kesempatan - 1;
                    Console.WriteLine($"You have {kesempatan} chance left");
                }
                if(kesempatan == 0){
                    Console.WriteLine($"Game over, the correct answer is {kata}");
                    Console.WriteLine("Bye bye....");
                    Environment.Exit(0);
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
