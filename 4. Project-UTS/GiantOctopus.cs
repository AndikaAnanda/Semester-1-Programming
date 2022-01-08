using System;

namespace Project_UTS
{
    class GiantOctopus : Enemy
    {
        public GiantOctopus(){
            Health = 400;
            attackPower = 9;
            Name = "GiantOctopus";
            Console.WriteLine(Name + " is blocking your way");

        }
        public override void Skill(Novice player){
            Console.WriteLine("Powerful Twist");
            player.GetHit(attackPower * 5);
        }
    
    }
}