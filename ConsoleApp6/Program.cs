using ConsoleApp6.NewFolder;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galery galery = new Galery();
            Car car1 = new Car { Name = "Camry", Color = "White", Speed = 180 };
            galery.AddCar(car1);
            Car car2 = new Car { Name = "BMW", Color = "Black", Speed = 240 };
            galery.AddCar(car2);
            Car car3 = new Car { Name = "Mercedes", Color = "Red", Speed = 220 };
            galery.AddCar(car3);
            galery.ShowAllCars();
            galery.GetAllCars();
            galery.FindCarById(3);
            galery.FindCarsBySpeedInterval(190,240);



        }
    }
}