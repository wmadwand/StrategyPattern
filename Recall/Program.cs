using System;

namespace Recall
{
    public interface IEngine
    {
        void Use();
    }

    public class Gasoline : IEngine
    {
        public void Use()
        {
            Console.WriteLine("PetrolMove");
        }
    }

    public class ElectroMove : IEngine
    {
        public void Use()
        {
            Console.WriteLine("ElectroMove");
        }
    }

    public class Car
    {
        public IEngine engine;

        public void Move()
        {
            engine.Use();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            IEngine gasolineEngine = new Gasoline();
            IEngine electroEngine = new ElectroMove();

            car.engine = gasolineEngine;

            car.engine = electroEngine;
        }
    }
}
