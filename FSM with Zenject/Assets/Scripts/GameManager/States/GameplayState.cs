using UnityEngine;
using Zenject;

namespace FSM.GameManager.States
{
    public class GameplayState : GameStateEntity
    {
        public override void Initialize()
        {
            Debug.Log("GameplayState Initialized");
        }

        public override void Start()
        {
            Debug.Log("GameplayState Started");
        }

        public override void Tick()
        {
        }

        public override void Dispose()
        {
            Debug.Log("GameplayState Disposed");
        }

        public class Factory : Factory<GameplayState>
        {
        }
    }
}