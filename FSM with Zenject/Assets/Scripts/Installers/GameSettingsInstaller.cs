using System;
using UnityEngine;
using Zenject;
using FSM.GameManager.States;

namespace FSM.Installers
{
    [CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
    public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
    {
        public GameStateSettings gameState;

        [Serializable]
        public class GameStateSettings
        {
            public GameOverState.Settings gameOverState;
            public VictoryState.Settings victoryState;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(gameState.gameOverState);
            Container.BindInstance(gameState.victoryState);
        }
    }
}