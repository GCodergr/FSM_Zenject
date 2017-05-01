using UnityEngine;
using Zenject;
using FSM.GameManager;


namespace UI
{
    public class StateChangeManager : MonoBehaviour
    {
        [Inject]
        readonly GameManager _gameManager;

        public void ChangeToMenu()
        {
            _gameManager.ChangeState(GameState.Menu);
        }

        public void ChangeToGameplay()
        {
            _gameManager.ChangeState(GameState.Gameplay);
        }

        public void ChangeToGameOver()
        {
            _gameManager.ChangeState(GameState.GameOver);
        }

        public void ChangeToVictory()
        {
            _gameManager.ChangeState(GameState.Victory);
        }
    }
}
