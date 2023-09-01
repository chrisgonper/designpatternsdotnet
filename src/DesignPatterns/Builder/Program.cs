using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        public enum CarType
        {
            Sedan,
            HatchBack,
            Suv
        }
        public class Car
        {
            public CarType Type { get; set; }
            public int WheelSize { get; set; }

            public override string ToString()
            {
                return $"Car Type {Type} with {WheelSize}' wheels";
            }
        }

        public interface ISpecifyCarType
        {
            ISpecifyWheelSize OfType(CarType carType);
        }
        public interface ISpecifyWheelSize
        {
            IBuildCar WithWheels(int size);
        }
        public interface IBuildCar
        {
            Car Build();
        }

        public class CarBuilder
        {
            private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
            {
                private Car car = new Car();
                public ISpecifyWheelSize OfType(CarType carType)
                {
                    this.car.Type = carType;
                    return this;
                }

                public IBuildCar WithWheels(int size)
                {
                    switch (this.car.Type)
                    {
                        case CarType.Sedan when size < 15 || size > 17:
                        case CarType.HatchBack when size < 17 || size > 20:
                        case CarType.Suv when size < 20:
                            throw new ArgumentException($"Wrong size of the wheel for {car.Type}");
                    }

                    this.car.WheelSize = size;
                    return this;
                }
                public Car Build()
                {
                    return this.car;
                }

            }
            public static ISpecifyCarType Create()
            {
                return new Impl();
            }
        }
        static void Main(string[] args)
        {
            Car car = CarBuilder.Create()
                                .OfType(CarType.HatchBack)
                                .WithWheels(17)
                                .Build();

            Console.WriteLine(car);

            Student student = new Student(10, new[] {10,9,9}, new DateTime(1999,10,10));

            Console.WriteLine(student);

            Console.ReadLine();
        }

        public class Student
        {
            public int Id { get; set; }
            public IEnumerable<int> Marks { get; set; }
            public DateTime DOB { get; set; }

            public Student(int id, IEnumerable<int> marks, DateTime dOB)
            {
                Id = id;
                Marks = marks;
                DOB = dOB;
            }
            public Student Get()
            {
                return this;
            }

            public override string ToString()
            {
                return $"Student with Id {this.Id} has marks [{string.Join(",", this.Marks)}]";
            }
        }
    }
}
