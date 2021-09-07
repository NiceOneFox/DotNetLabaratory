namespace GameArchitecture
{
    public interface IPlayer
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void TakeBonus(IBonus bonus);
        public void Move(IGameBoard gameBoard);
    }
}
