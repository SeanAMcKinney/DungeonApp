namespace Dungeon
{
    public interface IApp
    {
        void Execute();
    }

    public class App : IApp
    {
        private readonly IGameLoop _gameLoop;

        public App(IGameLoop gameLoop)
        {
            _gameLoop = gameLoop;
        }

        public void Execute()
        {
            _gameLoop.RunGame();
        }
    }
}
