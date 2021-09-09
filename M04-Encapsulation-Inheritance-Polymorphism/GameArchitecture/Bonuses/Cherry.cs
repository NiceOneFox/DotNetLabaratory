namespace GameArchitecture.Bonuses
{
    public class Cherry : IGameObject, IBonus
    {
        public int Score { get; set; }

        public Cherry(int x, int y, int score)
        {
            X = x;
            Y = y;
            Score = score;
        }

    }
}
