using ModestTree;
using FSM.GameManager.States;

namespace FSM.GameManager
{
    internal enum GameState
    {
        Menu,
        Gameplay,
        GameOver,
        Victory
    }

    public class GameStateFactory
    {
        readonly MenuState.Factory _menuFactory;
        readonly GameplayState.Factory _gameplayFactory;
        readonly GameOverState.Factory _gameOverFactory;
        readonly VictoryState.Factory _victoryFactory;

        public GameStateFactory(MenuState.Factory menuFactory,
                                GameplayState.Factory gameplayFactory,
                                GameOverState.Factory gameOverFactory,
                                VictoryState.Factory victoryFactory)
        {
            _menuFactory = menuFactory;
            _gameplayFactory = gameplayFactory;
            _gameOverFactory = gameOverFactory;
            _victoryFactory = victoryFactory;
        }

        /// <summary>
        /// Creates the requested game state entity
        /// </summary>
        /// <param name="gameState">State we want to create</param>
        /// <returns>The requested game state entity</returns>
        internal GameStateEntity CreateState(GameState gameState)
        {
            switch (gameState)
            {
                case GameState.Menu:
                    return _menuFactory.Create();

                case GameState.Gameplay:
                    return _gameplayFactory.Create();

                case GameState.GameOver:
                    return _gameOverFactory.Create();

                case GameState.Victory:
                    return _victoryFactory.Create();
            }

            throw Assert.CreateException("Code should not be reached");
        }
    }
}