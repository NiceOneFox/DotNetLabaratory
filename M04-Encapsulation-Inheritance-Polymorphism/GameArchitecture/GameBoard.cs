namespace GameArchitecture
{
    public class GameBoard : IGameBoard
    {
        public readonly int Width;

        public readonly int Height;   

        public GameBoard(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void CreateBoard()
        {

        }
    }
}