using TestTask.Objects;
using UnityEngine;

namespace TestTask.Game
{
    public sealed class GameCycleComponent : MonoBehaviour
    {
        [SerializeField] private TriggerableComponent _finishLine;

        private IGameCycle _gameCycle;
        public IGameCycle GameCycle => _gameCycle ??= new GameCycle(_finishLine.Triggerable);

        private void Awake()
        {
            _ = GameCycle;
        }
    }
}