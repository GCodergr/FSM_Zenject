using System;
using System.Collections;
using UnityEngine;
using Zenject;
using FSM.Helper;

namespace FSM.GameManager.States
{
    public class GameOverState : GameStateEntity
    {
        readonly AsyncProcessor _asyncProcessor;
        readonly GameManager _gameManager;
        readonly Settings _settings;

        public GameOverState(AsyncProcessor asyncProcessor,
                             GameManager gameManager,
                             Settings settings)
        {
            _asyncProcessor = asyncProcessor;
            _gameManager = gameManager;
            _settings = settings;
        }

        public override void Initialize()
        {
            Debug.Log("GameOverState Initialized");
        }

        public override void Start()
        {
            Debug.Log("GameOverState Started");
            _asyncProcessor.StartCoroutine(ProceedToMenu());
        }

        private IEnumerator ProceedToMenu()
        {
            yield return new WaitForSeconds(_settings.waitingTime);
            _gameManager.ChangeState(GameState.Menu);
        }

        public override void Tick()
        {
        }

        public override void Dispose()
        {
            Debug.Log("GameOverState Disposed");
        }

        [Serializable]
        public class Settings
        {
            public float waitingTime;
        }

        public class Factory : Factory<GameOverState>
        {
        }
    }
}
