using System;

namespace Project_UTS
{
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int attackPower { get; set; }
        public float Exp { get; set; }
        public bool IsDead { get; set; }
        public bool isRunningAway { get; set; }
        public int Energy { get; set; }

        public Novice(){
            Health = 100;
            attackPower = 1;
            Exp = 0.0f;
            Energy = 0;

        }
        public void Intro(){
                Console.WriteLine("- You were born as a fish living together with its colony.");
                Console.WriteLine("- One day, you help a clam that has problem while opening her jaws,");
                Console.WriteLine("- Then she gives you a golden pearl as a token of gratitude and says that one day this golden pearl will help you like you have helped her");
                Console.WriteLine("- After returning home, you ask the colony leader about this golden pearl.");
                Console.WriteLine("- Then leader said that this golden pearl can only be taken once every 500 years, and can increase the strength of its owner, but needs a trigger to activate it. ");
                Console.WriteLine("- The next day, the sea king, megalodon got information about it from his subordinates, came to your colony and wanted to seize the golden pearl.");
                Console.WriteLine("- Without further ado, megalodon eats up your entire colony and hopes to get hold of the golden pearl. ");
                Console.WriteLine("- Fortunately, you survived and managed to escape with the golden pearl in your hand.");
                Console.WriteLine("- You cry because your family was killed, your heart is filled with vengeance and determined to kill the megalodon");
                Console.WriteLine("- You realize that megalodon lives in a sea cave, protected by his subordinates.");
                Console.Write("- Now, the adventure begins......... (Press enter to contine)");
                Console.Read();

        }
        
        public virtual void Skill(Enemy enemy){
            Console.WriteLine("Skill : Small crush");
            attackPower *= 2;
            enemy.GetHit(attackPower);
        }

        public virtual void Defend(){
            Console.WriteLine("Defend");
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name + " get hit by " + hitValue);
            Health -= hitValue;
            if(Health <= 0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine("You are dead");
            IsDead = true;
        }
    }
}