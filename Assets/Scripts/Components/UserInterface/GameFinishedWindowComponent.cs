using TestTask.Game;
using UnityEngine;

namespace TestTask.UserInterface
{
    public sealed class GameFinishedWindowComponent : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] private GameCycleComponent _gameCycleComponent;

        [Header("Objects")] 
        [SerializeField] private GameObject _container;

        private void Awake()
        {
            _gameCycleComponent.GameCycle.OnGameStop += () => _container.SetActive(true);
        }
    }
}