using UnityEngine;

namespace TestTask.Cars
{
    public sealed class CarSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _carPrefabs;
        [SerializeField] private Transform _carContainer;

        private void Start()
        {
            SpawnCar(CarIdTransmitter.CarId);
        }

        private void SpawnCar(int carId)
        {
            Instantiate(_carPrefabs[carId], _carContainer);
        }
    }
}