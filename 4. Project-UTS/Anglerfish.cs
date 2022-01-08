using System;

namespace Project_UTS
{
    class Anglerfish : Novice
    {
        public Anglerfish(){
            Health = 250;
            attackPower = 15;
        }
        public override void Skill(Enemy enemy)
        {
            if (Energy >= 2){
                Console.WriteLine("Skill : Giant Fang");
                Console.WriteLine("........");
                enemy.GetHit(attackPower + 100);
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