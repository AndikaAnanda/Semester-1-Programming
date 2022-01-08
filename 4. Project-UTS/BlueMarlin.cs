using System;

namespace Project_UTS
{
    class BlueMarlin : Novice
    {
        Random rnd = new Random();
        public BlueMarlin(){
            Health = 300;
            attackPower = 6;
        }
        public override void Skill(Enemy enemy)
        {
            if (Energy >= 2){
                Console.WriteLine("Skill : Sword Snout");
                for (int i = 0; i <= Energy; i++){
                Console.WriteLine("SLASSHH");
                enemy.GetHit(attackPower + rnd.Next(3, 9));
                }
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