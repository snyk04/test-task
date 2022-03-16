using System;
using UnityEngine;

namespace TestTask.Objects
{
    public interface ITriggerable
    {
        event Action<Collider> OnTrigger;
    }
}