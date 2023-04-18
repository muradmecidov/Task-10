using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.NewFolder
{
    internal class Galery:Car
    {
       
        public int Id;
        public Car[] cars;

        public void AddCar(Car car)
        {
            Array.Resize(ref cars ,cars.Length+1);
            cars[cars.Length-1]=car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Name,car.Speed,car.Color);

            }   
        }
        public Car[] GetAllCars() 
        { 
            return cars;
        }
        public void FindCarById(int id)
        {
            Console.WriteLine(cars[id].Name);
            Console.WriteLine(cars[id].Speed);
            Console.WriteLine(cars[id].Color);

        }
        public void FindCarsBySpeedInterval(int minSpeed,int maxSpeed)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Speed > minSpeed && cars[i].Speed<maxSpeed)
                {
                    Console.WriteLine(cars[i].Name);
                    Console.WriteLine(cars[i].Speed);
                    Console.WriteLine(cars[i].Color);
                }
            }
        }





    }
}
