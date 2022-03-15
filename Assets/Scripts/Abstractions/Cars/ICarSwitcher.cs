using System;

namespace TestTask.Cars
{
    public interface ICarSwitcher
    {
        event Action OnCarSwitch;
    
        public int CurrentCarId { get; }
        public int AmountOfCars { get; }

        void ChoosePreviousCar();
        void ChooseNextCar();
    }
}