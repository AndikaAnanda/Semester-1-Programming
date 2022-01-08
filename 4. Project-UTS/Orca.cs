using System;

namespace Project_UTS
{
    class Orca : Enemy
    {
        public Orca(){
            Health = 200;
            attackPower = 6;
            Name = "Orca";
            Console.WriteLine(Name + " is blocking your way");

        }
        public override void Skill(Novice player){
            Console.WriteLine("Beast Mode");
            player.GetHit(attackPower * 3);
        }
    
    }
}