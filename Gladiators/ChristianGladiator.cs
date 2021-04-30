using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class ChristianGladiator: Gladiator, IFighter
    {
        private Random rnd = new Random();

        public override bool IsFreed
        {
            get => isFreed;
        }

        public override Attack(Gladiator enemy)
        {
            return false;
        }

        public override BeingAttacked(sbyte enemyStrength)
        {
            int randomResult = rnd.Next(6);
            if (randomResult < 5)
            {
                this.Die();
            }
        }

        public ChristianGladiator(byte years, OriginType origin): base(years, origin)
        {

        }
    }
}
