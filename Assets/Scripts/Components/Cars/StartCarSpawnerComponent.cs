using UnityEngine;

namespace TestTask.Cars
{
    public sealed class StartCarSpawnerComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _carPrefabs;
        [SerializeField] private Transform _carContainer;
        [SerializeField] private Vector3 _carPosition;
        [SerializeField] private Vector3 _carRotation;

        private void Start()
        {
            Instantiate(
                _carPrefabs[CarIdTransmitter.CarId],
                _carPosition, 
                Quaternion.Euler(_carRotation),
                _carContainer
                );
        }
    }
}