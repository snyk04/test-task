using UnityEngine;

namespace TestTask.Cars
{
    public sealed class CarSwitcherComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _carsPrefabs;
        [SerializeField] private Vector3 _carPosition;
        [SerializeField] private Vector3 _carRotation;
        [SerializeField] private Transform _carContainer;
    
        private ICarSwitcher _carSwitcher;
        public ICarSwitcher CarSwitcher 
        {
            get
            {
                return _carSwitcher ??= new CarSwitcher(_carsPrefabs, _carPosition, _carRotation, _carContainer);
            }
        }

        private void Awake()
        {
            _ = CarSwitcher;
        }

        public void ChoosePreviousCar()
        {
            CarSwitcher.ChoosePreviousCar();
        }
        public void ChooseNextCar()
        {
            CarSwitcher.ChooseNextCar();
        }
    }
}