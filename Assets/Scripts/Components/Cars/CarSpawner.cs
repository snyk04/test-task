using UnityEngine;

namespace TestTask.Cars
{
    public sealed class CarSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _carPrefabs;
        [SerializeField] private Transform _carContainer;
        [SerializeField] private Vector3 _carPosition;
        [SerializeField] private Vector3 _carRotation;

        private void Start()
        {
            SpawnCar(CarIdTransmitter.CarId, _carPosition, Quaternion.Euler(_carRotation));
        }

        private void SpawnCar(int carId, Vector3 carPosition, Quaternion carRotation)
        {
            Instantiate(_carPrefabs[carId], carPosition, carRotation, _carContainer);
        }
    }
}