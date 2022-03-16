using System;
using UnityEngine;

namespace TestTask.Objects
{
    public sealed class Triggerable : ITriggerable
    {
        public event Action<Collider> OnTrigger;
        
        public void OnTriggerEnter(Collider collider)
        {
            OnTrigger?.Invoke(collider);
        }
    }
}