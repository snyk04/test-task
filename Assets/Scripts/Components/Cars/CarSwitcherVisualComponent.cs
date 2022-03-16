using UnityEngine;
using UnityEngine.UI;

namespace TestTask.Cars
{
    public sealed class CarSwitcherVisualComponent : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] private CarSwitcherComponent _carSwitcherComponent;
    
        [Header("Buttons")]
        [SerializeField] private Button _choosePreviousCarButton;
        [SerializeField] private Button _chooseNextCarButton;

        private void Awake()
        {
            _carSwitcherComponent.CarSwitcher.OnCarSwitch += CheckButtons;
        }
        private void Start()
        {
            CheckButtons();
        }

        private void CheckButtons()
        {
            int currentCarId = _carSwitcherComponent.CarSwitcher.CurrentCarId;
            int amountOfCars = _carSwitcherComponent.CarSwitcher.AmountOfCars;

            _choosePreviousCarButton.interactable = currentCarId != 0;
            _chooseNextCarButton.interactable = currentCarId != amountOfCars - 1;
        }
    }
}