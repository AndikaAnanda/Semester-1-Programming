using System;

namespace Project_UTS
{
    class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int attackPower { get; set; }
        public bool IsDead { get; set; }
        public bool isStunned { get; set; }
        public bool isPoisoned { get; set; }

        Random rnd = new Random();
        
        public void GetHit(int hitValue){
            Console.WriteLine(Name + " get hit by " + hitValue);
            Health -= hitValue;
            if(Health <= 0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name + " is dead");
            IsDead = true;
        }
        public virtual void Skill(Novice player){
            player.GetHit(attackPower * 2);
        }
        public virtual void BossSkill(Novice player){
            player.GetHit(attackPower * 3);
        }
    }
    
}
