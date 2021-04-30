namespace Gladiators
{
    interface IFighter
    {
        public bool Attack(Gladiators enemy);

        public void BeingAttacked(sbyte enemyStrength);
    }
}