﻿using System;
namespace Strategy
{
    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public PetrolMove()
        {
        }

        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }

    class Car
    {
        protected int passengers; // кол-во пассажиров
        protected string model; // модель автомобиля

        public IMovable Movable { private get; set; }

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }

        public void Move()
        {
            Movable.Move();
        }
    }

    class Program1
    {
        static void Main1(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
}
