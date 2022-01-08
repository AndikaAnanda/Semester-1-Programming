using System;

namespace Project_UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fish Adventure game!");
            Console.Write("Please tell us your name, Adventurer : ");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi " + player.Name + ", are you ready to start the game? [y/n]");
            string bReady = Console.ReadLine();
            if (bReady == "y"){
                Console.WriteLine("======== INTRO =======");
                player.Intro();
                Console.WriteLine("======== Level 1 =======");
                Jellyfish jellyfish = new Jellyfish();
                Encounter encounter1 = new Encounter(player, jellyfish);
                if (player.Exp >= 2 && player.Exp <= 16){
                Console.WriteLine("The golden pearl suddenly shines bright, and finally it give you the power to change your body to be a powerful fish");
                Console.WriteLine("Please select your choice : ");
                Console.WriteLine("1. Baraccuda");
                Console.WriteLine("2. Lionfish");
                Console.WriteLine("3. Anglerfish");
                Console.WriteLine("4. Blue Marlin");
                string jobChoice = Console.ReadLine();
                switch (jobChoice){
                    case "1":
                    player = new Baraccuda();
                    break;
                    case "2":
                    player = new Lionfish();
                    break;
                    case "3":
                    player = new Anglerfish();
                    break;
                    case "4":
                    player = new BlueMarlin();
                    break;
                }
                }
                
                Console.WriteLine("======== Level 2 =======");
                Orca orca = new Orca();
                Encounter encounter2 = new Encounter(player, orca);
                Console.WriteLine("======== Level 3 =======");
                GreatWhiteShark greatWhiteShark = new GreatWhiteShark();
                Encounter encounter3 = new Encounter(player, greatWhiteShark);
                Console.WriteLine("======== Level 4 =======");
                GiantOctopus giantOctopus = new GiantOctopus();
                Encounter encounter4 = new Encounter(player, giantOctopus);
                TreasureBox treasureBox = new TreasureBox();
                Console.WriteLine("======== Boss Level =======");
                Megalodon megalodon = new Megalodon();
                Encounter bossEncounter = new Encounter(player, megalodon);


            } else {
                Console.WriteLine("Okay " + player.Name + ", see you next time");
                Console.Read();
                Environment.Exit(0);
            }
        }
    }
}
