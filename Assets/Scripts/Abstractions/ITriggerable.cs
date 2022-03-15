using System;
using UnityEngine;

namespace TestTask
{
    public interface ITriggerable
    {
        event Action<Collider> OnTrigger;
    }
}