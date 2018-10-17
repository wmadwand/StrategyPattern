using System;
namespace StrategyMS01
{
    public interface IMoveable
    {
        void Move();
    }

    public class PetrolMove : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("PetrolMove");
        }
    }

    public class ElectricMove : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("ElectricMove");
        }
    }

    public class Car
    {
        protected int _passengersCount;
        protected string _model;

        public Car(int passengersCount, string model, IMoveable moveable)
        {
            _passengersCount = passengersCount;
            _model = model;
            Moveable = moveable;
        }

        public IMoveable Moveable { private get; set; }

        public void Move()
        {
            Moveable.Move();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "BMW", new PetrolMove());
            car.Move();

            car.Moveable = new ElectricMove();
            car.Move();
        }
    }
}
