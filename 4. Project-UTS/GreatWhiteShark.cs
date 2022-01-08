using System;

namespace Project_UTS
{
    class GreatWhiteShark : Enemy
    {
        public GreatWhiteShark(){
            Health = 300;
            attackPower = 8;
            Name = "GreatWhiteShark";
            Console.WriteLine(Name + " is blocking your way");

        }
        public override void Skill(Novice player){
            Console.WriteLine("Destuctive Bite");
            player.GetHit(attackPower * 4);
        }
    
    }
}