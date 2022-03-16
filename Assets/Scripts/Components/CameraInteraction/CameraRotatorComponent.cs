using UnityEngine;

namespace TestTask.CameraInteraction
{
    public sealed class CameraRotatorComponent : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private Vector3 _pointToAlign;

        private Vector3 _lastTapPosition;

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _lastTapPosition = _camera.ScreenToViewportPoint(Input.mousePosition);
            }

            if (Input.GetMouseButton(0))
            {
                Vector3 direction = _camera.ScreenToViewportPoint(Input.mousePosition) - _lastTapPosition;

                _camera.transform.RotateAround(
                    _pointToAlign,
                    Vector3.up,
                    direction.x * 180
                );

                _lastTapPosition = _camera.ScreenToViewportPoint(Input.mousePosition);
            }
        }
    }
}