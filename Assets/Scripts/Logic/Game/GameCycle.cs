using System;
using TestTask.Objects;
using UnityEngine;

namespace TestTask.Game
{
    public sealed class GameCycle : IGameCycle
    {
        public event Action OnGameStop;

        public GameCycle(ITriggerable finishLine)
        {
            finishLine.OnTrigger += TryToFinishGame;
        }

        private void TryToFinishGame(Collider collider)
        {
            var carController = collider.transform.GetComponentInParent<RCC_CarControllerV3>();
            
            if (carController != null)
            {
                RCC.SetControl(carController, false);
                carController.speed = 0;
                RCC_SceneManager.Instance.activePlayerCamera.cameraMode = RCC_Camera.CameraMode.FIXED;
                
                OnGameStop?.Invoke();
            }
        }
    }
}