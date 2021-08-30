namespace GameArchitecture
{
    public interface IMonster
    {
        public void Attack(ICreature creature);
        public void Hunt();
    }
}
