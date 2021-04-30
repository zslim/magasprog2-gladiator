using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class FightingGladiator: Gladiator, IFighter
    {
        private sbyte fightingSpirit;
        public sbyte FightingSpirit { 
            get => fightingSpirit; 
            private set
            {
                if (value >= -5 && value <= 5)
                {
                    fightingSpirit = value;
                }
                else
                {
                    throw new FightingSpiritException("Invalid fighting spirit value: {0}", value);
                }
            } 
        }

        public override bool Attack(Gladiator enemy)
        {
            if (IsFreed || enemy.IsFreed || !IsAlive || !enemy.IsAlive)
            {
                return false;
            }
            enemy.BeingAttacked(Years + FightingSpirit);
            return true;
        }

        public override BeingAttacked(sbyte enemyStrength)
        {
            sbyte ownStrength = Years + FightingSpirit;
            if (ownStrength < enemyStrength)
            {
                Die();
            }
        }
    }
}
