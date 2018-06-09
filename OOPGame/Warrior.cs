using System;

namespace Nevinson.OOPGame
{
    public class Warrior
    {
        public Warrior(string name,
                       double health,
                       double attackMax,
                       double blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        Random rnd = new Random();

        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
