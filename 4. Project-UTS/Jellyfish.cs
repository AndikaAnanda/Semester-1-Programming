using System;

namespace Project_UTS
{
    class Jellyfish : Enemy
    {
        public Jellyfish(){
            Health = 50;
            attackPower = 1;
            Name = "Jellyfish";
            Console.WriteLine(Name + " is blocking your way");

        }
        public override void Skill(Novice player){
            Console.WriteLine("Electric shock");
            base.Skill(player);
        }
    
    }
}