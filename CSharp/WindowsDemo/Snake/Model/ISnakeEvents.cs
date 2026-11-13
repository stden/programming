namespace Snake.Model
{
    public interface ISnakeEvents
    {
        void StartGame();
        void GameOver(string gameResult);
    }
}