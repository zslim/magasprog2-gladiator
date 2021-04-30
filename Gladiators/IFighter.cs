namespace Gladiators
{
    interface IFighter
    {
        public bool Attack(Gladiator enemy);

        public void BeingAttacked(sbyte enemyStrength);
    }
}