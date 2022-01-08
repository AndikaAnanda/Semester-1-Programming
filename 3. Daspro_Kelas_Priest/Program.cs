using System;

namespace Daspro_Kelas_Priest
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Welcome to simple adventure game, created by Andika Ananda.");
            Console.WriteLine("Could you tell me your name, Adventurer?");

            //menginisiasi player
            Novice player = new Novice();

            player.Name = Console.ReadLine();
            Console.WriteLine("Hello " + player.Name + ", ready to play? [y/n]");
            string bReady = Console.ReadLine();
            if (bReady == "y"){
                Console.WriteLine("Okay, lets start your journey!(Press enter to continue.)");
                Console.Read();
                Enemy1 enemy1 = new Enemy1("Slime");
                Console.WriteLine(player.Name + ", you suddenly surrounded by " + enemy1.Name + " from the bushes,");
                Console.WriteLine("Choose your action! :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Defend");
                Console.WriteLine("5. Run");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1" :
                        Console.WriteLine(player.Name + " use Single Attack to " + enemy1.Name);
                        enemy1.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy1.Name + " = " + enemy1.Health);
                        break;
                        case "2":
                        player.Swing();
                        enemy1.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.9f;
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy1.Name + " = " + enemy1.Health);
                        break;
                        case "3":
                        player.Heal();
                        player.Exp = player.Exp + 0.6f;
                        player.GetHeal(player.HealPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy1.Name + " = " + enemy1.Health);
                        break;
                        case "4":
                        player.Rest();
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy1.Name + " = " + enemy1.Health);
                        break;
                        case "5":
                        Console.WriteLine(player.Name + " run away from " + enemy1.Name + "!");
                        enemy1.IsDead = true;
                        Console.Read();
                        break;
                    }
                }
                Console.WriteLine(player.Name + ", your experience point is increased to " + player.Exp + "!");
                
                Console.WriteLine("You managed to beat the first enemy, time to continue your journey.(Press enter to continue.)");
                Console.Read();
                Enemy2 enemy2 = new Enemy2("Bandits");
                Console.WriteLine(player.Name + ", some " + enemy2.Name + " are try to attacking you,");
                Console.WriteLine("Choose your action! :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Defend");
                Console.WriteLine("5. Run");
                while (!player.IsDead && !enemy2.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                        Console.WriteLine(player.Name + " use Single Attack to " + enemy2.Name);
                        enemy2.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.3f;
                        enemy2.Attack(enemy2.AttackPower);
                        player.GetHit(enemy2.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy2.Name + " = " + enemy2.Health);
                        break;
                        case "2":
                        player.Swing();
                        enemy2.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.9f;
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy2.Name + " = " + enemy2.Health);
                        break;
                        case "3":
                        player.Heal();
                        player.Exp = player.Exp + 0.6f;
                        player.GetHeal(player.HealPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy2.Name + " = " + enemy2.Health);
                        break;
                        case "4":
                        player.Rest();
                        enemy2.Attack(enemy2.AttackPower);
                        player.GetHit(enemy2.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy2.Name + " = " + enemy2.Health);
                        break;
                        case "5":
                        Console.WriteLine(player.Name + " run away from " + enemy2.Name + "!");
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy2.Name + " = " + enemy2.Health);
                        break;
                    }
                }
                Console.WriteLine(player.Name + ", your experience point is increased to " + player.Exp + "!");

                Console.WriteLine("You managed to beat the second enemy, time to continue your journey.(Press enter to continue.)");
                Console.Read();
                Enemy3 enemy3 = new Enemy3("Big Cockroach");
                Console.WriteLine(player.Name + ", " + enemy3.Name + " are try to attacking you,");
                Console.WriteLine("Choose your action! :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Defend");
                Console.WriteLine("5. Run");
                while (!player.IsDead && !enemy3.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                        Console.WriteLine(player.Name + " use Single Attack to " + enemy3.Name);
                        enemy3.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.3f;
                        enemy3.Attack(enemy3.AttackPower);
                        player.GetHit(enemy3.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy3.Name + " = " + enemy3.Health);
                        break;
                        case "2":
                        player.Swing();
                        enemy3.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.9f;
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy3.Name + " = " + enemy3.Health);
                        break;
                        case "3":
                        player.Heal();
                        player.Exp = player.Exp + 0.6f;
                        player.GetHeal(player.HealPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy3.Name + " = " + enemy3.Health);
                        break;
                        case "4":
                        player.Rest();
                        enemy3.Attack(enemy3.AttackPower);
                        player.GetHit(enemy3.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + enemy3.Name + " = " + enemy3.Health);
                        break;
                        case "5":
                        Console.WriteLine(player.Name + " run away from " + enemy3.Name + "!");
                        Console.Read();
                        break;
                    }
                }
                Console.WriteLine(player.Name + ", your experience point is increased to " + player.Exp + "!");

                Console.WriteLine("You managed to beat the third enemy, time to continue your journey.(Press enter to continue.)");
                Console.Read();
                Boss worldBoss = new Boss("Kraken");
                if(worldBoss.Health > 500){
                    worldBoss.AttackPower = 3 * player.AttackPower;
                } else{
                    worldBoss.AttackPower = player.Health * 3 / 10;
                }
                Console.WriteLine("Finally, this is the last creature you must defeating. " + worldBoss.Name + " is appear in front of you!!");
                Console.WriteLine("Choose your action! :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Defend");
                Console.WriteLine("5. Run");
                while (!player.IsDead && !worldBoss.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                        Console.WriteLine(player.Name + " use Single Attack to " + worldBoss.Name);
                        worldBoss.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.3f;
                        worldBoss.Attack(worldBoss.AttackPower);
                        player.GetHit(worldBoss.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + worldBoss.Name + " = " + worldBoss.Health);
                        break;
                        case "2":
                        player.Swing();
                        worldBoss.GetHit(player.AttackPower);
                        player.Exp = player.Exp + 0.9f;
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + worldBoss.Name + " = " + worldBoss.Health);
                        break;
                        case "3":
                        player.Heal();
                        player.Exp = player.Exp + 0.6f;
                        player.GetHeal(player.HealPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + worldBoss.Name + " = " + worldBoss.Health);
                        break;
                        case "4":
                        player.Rest();
                        worldBoss.Attack(worldBoss.AttackPower);
                        player.GetHit(worldBoss.AttackPower);
                        Console.WriteLine("HP " + player.Name + " = " + player.Health + " | HP " + worldBoss.Name + " = " + worldBoss.Health);
                        break;
                        case "5":
                        Console.WriteLine(player.Name + " run away from " + worldBoss.Name + "!");
                        Console.Read();
                        break;
                    }
                }
                Console.WriteLine(player.Name + ", your experience point is increased to " + player.Exp + "!");





            } else {
                Console.WriteLine("Okay, no problem. Have a nice day..");
                Console.Read();
            }
        }
    }

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int SkillSlot { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public float Exp { get; set; }
        public int Mana { get; set; }
        public int HealPower { get; set; }

        Random rnd = new Random(); //menginisialisasi fungsi random

        //constructor
        public Novice(){
            Health = 100;
            Name = "Newbie";
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Exp = 0f;
            Mana = 0;
            HealPower = 2;
            
        }

        //method
        public void Swing(){
            Reset();
            if (SkillSlot > 0){
                Console.WriteLine("ORRRAAA!!");
                AttackPower = AttackPower + rnd.Next(6,12);
                SkillSlot--;
            } else {
                AttackPower = 0;
                Console.WriteLine("Run out of energy");
            }
        }

        public void Heal(){
            if (Mana > 0){
                HealPower = HealPower + rnd.Next(6,12);
                Mana--;
            } else {
                Console.WriteLine("Run out of Mana");
            }
            
        }

        public void GetHeal(int HealValue){
            Console.WriteLine(Name + " healed by " + HealValue);
            Health = Health + HealValue;
            if (Health >= 100){
                Health = 100;
                Console.WriteLine("Your HP is full right now");
            }
        }

        public void GetHit(int HitValue){
            Console.WriteLine(Name + " attacked by " + HitValue);
            Health = Health - HitValue;
            if (Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Reset(){
            AttackPower = 1;
        }        

        public void Rest(){
            Console.WriteLine("Energy and Mana is being restored.");
            SkillSlot = SkillSlot + 3;
            AttackPower = 1;
            Mana = Mana + 3;
            HealPower = 1;
        }
        public void Die(){
            Console.WriteLine(Name + " is dead, game over....");
            IsDead = true;
        }
    }

    class Enemy1
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random(); //menginisialisasi fungsi random

        //constructor
        public Enemy1(string name){
            Health = 25;
            Name = name;
        }

        //method
        public void Attack(int damage){
            AttackPower = AttackPower + rnd.Next(1,6);
        }
        public void GetHit(int HitValue){
            Console.WriteLine(Name + " is attacked by " + HitValue);
            Health = Health - HitValue;
            if (Health <= 0){
                Health = 0;
                Die();
            }

        }
        public void Die(){
            Console.WriteLine(Name + " is dead");
            IsDead = true;
        }
    }

    class Enemy2
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random(); //menginisialisasi fungsi random

        //constructor
        public Enemy2(string name){
            Health = 25;
            Name = name;
        }

        //method
        public void Attack(int damage){
            AttackPower = AttackPower + rnd.Next(3,8);
        }
        public void GetHit(int HitValue){
            Console.WriteLine(Name + " is attacked by " + HitValue);
            Health = Health - HitValue;
            if (Health <= 0){
                Health = 0;
                Die();
            }

        }
        public void Die(){
            Console.WriteLine(Name + " is dead!");
            IsDead = true;
        }
    }

    class Enemy3
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random(); //menginisialisasi fungsi random

        //constructor
        public Enemy3(string name){
            Health = 25;
            Name = name;
        }

        //method
        public void Attack(int damage){
            AttackPower = AttackPower + rnd.Next(5,10);
        }
        public void GetHit(int HitValue){
            Console.WriteLine(Name + " is attacked by " + HitValue);
            Health = Health - HitValue;
            if (Health <= 0){
                Health = 0;
                Die();
            }

        }
        public void Die(){
            Console.WriteLine(Name + " is dead!");
            IsDead = true;
        }
    }

    class Boss
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public int Mana { get; set; }
        Random rnd = new Random(); //menginisialisasi fungsi random

        public Boss(string name){
            Health = 1000;
            Mana = 0;
            IsDead = false;
            Name = name;
            AttackPower = 1;
        }

        public void Attack(int damage){
            AttackPower = AttackPower;
        }

        public void GetHit(int HitValue){
            int deathChance = rnd.Next(1,101);
            if(deathChance != 1){
                Console.WriteLine(Name + " is attacked by " + HitValue);
                Health = Health - HitValue;
                if (Health <= 0){
                    Health = 0;
                    Die();
                } else if (Health <= 500){
                    SkillAttack();
                }
            } else {
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name + " is dead!");
            IsDead = true;
        }

        public void SkillAttack(){
            Console.WriteLine("The boss suddenly sucked up sea water and spray it everywhere!");
        }
    }
}
