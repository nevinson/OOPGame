using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    class Warrior
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

        // Name Health Attack Maximum Block Maximum
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random numbers
        Random rnd = new Random();

        // Attack
        // Generate a random attack between 1 
        // and the Attack Maximum
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        // Block
        // Generate a random block between 1 
        // and the Block Maximum
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
