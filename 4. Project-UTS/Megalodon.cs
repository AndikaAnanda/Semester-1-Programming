using System;

namespace Project_UTS
{
    class Megalodon : Enemy
    {
        public Megalodon(){
            Health = 1000;
            attackPower = 20;
            Name = "Megalodon";
            Console.WriteLine(Name + " is blocking your way");
            Console.WriteLine("Finally you find the main enemy who has made you suffer");
            Console.WriteLine("Time for revenge!");

        }
        public override void Skill(Novice player){
            Console.WriteLine("Deadly Shockwave");
            player.GetHit((int)0.3 * player.Health);
        }
        public override void BossSkill(Novice player)
        {
            Console.WriteLine("Sea King Punishment");
            player.GetHit(player.Health);
        }
    }
}