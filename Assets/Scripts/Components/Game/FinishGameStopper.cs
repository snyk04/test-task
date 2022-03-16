using TestTask.Cars;
using TestTask.Objects;
using UnityEngine;

namespace TestTask.Game
{
    public sealed class FinishGameStopper : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TriggerableComponent _triggerableComponent;

        [Header("Objects")]
        [SerializeField] private GameObject _gameStopWindow;
        
        private void Awake()
        {
            _triggerableComponent.Triggerable.OnTrigger += TryToFinishGame;
        }

        private void TryToFinishGame(Collider collider)
        {
            var carController = collider.transform.GetComponentInParent<RCC_CarControllerV3>();
            
            if (carController != null)
            {
                _gameStopWindow.SetActive(true);
                RCC.SetControl(carController, false);
                carController.speed = 0;
                RCC_SceneManager.Instance.activePlayerCamera.cameraMode = RCC_Camera.CameraMode.FIXED;
            }
        }
    }
}