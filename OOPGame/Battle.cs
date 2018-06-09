using System;

namespace Nevinson.OOPGame
{
    public class Battle
    {
        public static void StartFight(Warrior warrior1,
                                      Warrior warrior2)
        {
            while (true)
            {
                 if (GetAttackResult(warrior1, warrior2)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        private static string GetAttackResult(Warrior warriorA, 
                                              Warrior warriorB)
        {
            double warAAttackAmount = warriorA.Attack();
            double warBBlockAmount = warriorB.Block();

            double dmg2WarB = warAAttackAmount - warBBlockAmount;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine($"{warriorA.Name} Attacks {warriorB.Name} and Deals {dmg2WarB} Damage");

            Console.WriteLine($"{warriorB.Name} Has {warriorB.Health} Health \n");

            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has Died and {warriorA.Name} is Victorious \n");

                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
