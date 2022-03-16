using UnityEngine;

namespace TestTask.Objects
{
    public sealed class TriggerableComponent : MonoBehaviour
    {
        private Triggerable _triggerable;
        public ITriggerable Triggerable 
        {
            get
            {
                return _triggerable ??= new Triggerable();
            }
        }

        private void Awake()
        {
            _ = Triggerable;
        }
        private void OnTriggerEnter(Collider other)
        {
            _triggerable.OnTriggerEnter(other);
        }
    }
}