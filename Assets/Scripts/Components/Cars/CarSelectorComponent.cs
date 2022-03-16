using UnityEngine;

namespace TestTask.Cars
{
    public sealed class CarSelectorComponent : MonoBehaviour
    {
        [SerializeField] private CarSwitcherComponent _carSwitcherComponent;

        public void Select()
        {
            CarIdTransmitter.CarId = _carSwitcherComponent.CarSwitcher.CurrentCarId;
        }
    }
}