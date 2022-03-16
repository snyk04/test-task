using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TestTask.Cars
{
    public sealed class CarSwitcher : ICarSwitcher
    {
        private readonly GameObject[] _carsPrefabs;
        private readonly Vector3 _carPosition;
        private readonly Vector3 _carRotation;
        private readonly Transform _carContainer;
    
        private GameObject[] _cars;
    
        public event Action OnCarSwitch;
        public int CurrentCarId { get; private set; }
        public int AmountOfCars => _carsPrefabs.Length;
        
        public CarSwitcher(GameObject[] carsPrefabs, Vector3 carPosition, Vector3 carRotation, Transform carContainer)
        {
            _carsPrefabs = carsPrefabs;
            _carPosition = carPosition;
            _carRotation = carRotation;
            _carContainer = carContainer;
            
            SpawnCars();
            ChooseCar(0);
        }
    
        public void ChoosePreviousCar()
        {
            ChooseCar(CurrentCarId - 1);
        }
        public void ChooseNextCar()
        {
            ChooseCar(CurrentCarId + 1);
        }
        
        private void ChooseCar(int carId)
        {
            _cars[CurrentCarId].SetActive(false);
            _cars[carId].SetActive(true);
            
            CurrentCarId = carId;
            CarIdTransmitter.CarId = carId;

            OnCarSwitch?.Invoke();
        }
        private void SpawnCars()
        {
            int amountOfCars = _carsPrefabs.Length;
            _cars = new GameObject[amountOfCars];
    
            for (var i = 0; i < amountOfCars; i++)
            {
                _cars[i] = Object.Instantiate(
                    _carsPrefabs[i],
                    _carPosition,
                    Quaternion.Euler(_carRotation),
                    _carContainer
                    );
    
                var carController = _cars[i].GetComponent<RCC_CarControllerV3>();
                RCC.SetControl(carController, false);
                carController.engineRunning = false;
                _cars[i].SetActive(false);
            }
        }
    }
}