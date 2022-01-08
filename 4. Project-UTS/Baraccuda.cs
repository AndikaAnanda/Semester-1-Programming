using System;

namespace Project_UTS
{
    class Baraccuda : Novice
    {
        public static int stealthDuration { get; set; }
        public Baraccuda(){
            Health = 300;
            attackPower = 8;
        }
        public override void Skill(Enemy enemy)
        {
            if (Energy >= 2){
                Console.WriteLine("Skill : Stealth Bite");
                stealthDuration = 2;
                Console.WriteLine("........");
                Console.WriteLine(enemy.Name + " is being invisible for " + stealthDuration + "turn");
                enemy.isStunned = true;
                enemy.GetHit(attackPower * 3);
                Energy = 0;
            } else {
                Console.WriteLine("Energy = " + Energy);
                Console.WriteLine("You don't have enough Energy point");
            }
        }
        public override void Defend()
        {
            base.Defend();
            Console.WriteLine("Regenerating Energy point");
            Energy++;
        }
    }
}