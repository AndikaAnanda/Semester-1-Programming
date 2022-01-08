using System;

namespace Project_UTS
{
    class Encounter
    {
        public Encounter(Novice player, Enemy enemy){
            Console.WriteLine(player.Name + " is encountering " + enemy.Name);
            Console.WriteLine(enemy.Name + " is attacking you");
            Console.WriteLine("Choose your action :");
            Console.WriteLine("1. Normal Attack");
            Console.WriteLine("2. Skill");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run");

            while (!enemy.IsDead && !player.IsDead && !player.isRunningAway){
                if (Baraccuda.stealthDuration <= 0){
                    enemy.isStunned = false;
                } else if (enemy.isStunned){
                    Baraccuda.stealthDuration--;
                }
                if (Lionfish.toxicDuration <= 0){
                    enemy.isPoisoned = false;
                } else if (enemy.isPoisoned){
                    Lionfish.toxicDuration--;
                }


                Console.Write("Choose your action : ");
                Random rnd = new Random();
                string playerAction = Console.ReadLine();
                switch (playerAction){
                    case "1":
                    Console.WriteLine(player.Name + " doing normal attack");
                    enemy.GetHit(player.attackPower);
                    if (!enemy.isStunned){
                        player.GetHit(enemy.attackPower);
                    }
                    if (enemy.isPoisoned){
                        enemy.GetHit(player.attackPower);
                    }
                    player.Exp += 0.3f;
                    Console.WriteLine("Player health : " + player.Health + " | Enemy health : " + enemy.Health);
                    break;
                    case "2":
                    player.Skill(enemy);
                    if (enemy.isPoisoned){
                        enemy.GetHit(player.attackPower);
                    }
                    player.Exp += 0.5f;
                    Console.WriteLine("Player health : " + player.Health + " | Enemy health : " + enemy.Health);
                    break;
                    case "3":
                    player.Defend();
                    if(!enemy.isStunned){
                        if (rnd.Next(1,4) == 2){
                        enemy.Skill(player);
                    } else {
                        player.GetHit(enemy.attackPower);
                    }
                    if (enemy.isPoisoned){
                        enemy.GetHit(player.attackPower);
                    }
                    }
                    player.Exp += 0.3f;
                    Console.WriteLine("Player health : " + player.Health + " | Enemy health : " + enemy.Health);
                    break;
                    case "4":
                    Console.WriteLine(player.Name + " attempt to run away, maybe next time");
                    player.isRunningAway = true;
                    player.Exp = 0;
                    Console.Read();
                    break;
                }
                
            }
            if (enemy.IsDead){
                Console.WriteLine("You get " + player.Exp + " exp point");
                Console.WriteLine("Level Up");
                player.Health += 100;
                player.attackPower += 10;
                Console.WriteLine("Player health : " + player.Health + " | Player attPower : " + player.attackPower);
            } else if (player.IsDead){
                Console.WriteLine("Maybe next time");
                Console.WriteLine("See you..");
                Environment.Exit(0);
            }
        }
    }
}