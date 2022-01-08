using System;

namespace Project_UTS
{
    class Lionfish : Novice
    {
        public static int toxicDuration { get; set; }
        public Lionfish(){
            Health = 200;
            attackPower = 10;
        }
        public override void Skill(Enemy enemy)
        {
            if (Energy >= 2){
                Console.WriteLine("Skill : Poisonous thorns");
                toxicDuration = 2;
                Console.WriteLine("........");
                Console.WriteLine(enemy.Name + " is being poisoned for " + toxicDuration + "turn");
                enemy.isPoisoned = true;
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