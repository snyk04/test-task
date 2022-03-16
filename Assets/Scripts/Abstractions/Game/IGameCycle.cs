using System;

namespace TestTask.Game
{
    public interface IGameCycle
    {
        event Action OnGameStop;
    }
}