using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            RunParkingLot();

            Console.Read();
        }
        

        public static void RunParkingLot()
        {
             void SetCarOnParking(Car car)
            {
                if (car.parkinglot.GetAvailableParking() > 0)
                {
                    car.parkinglot.ParkCar(car);
                }
            }

            //List<Car> cars = new List<Car>();


            Car c1 = new Car("Toyota", "Camry", 5);
            Car c2 = new Car("Toyota", "Corola", 10000);
            Car c3 = new Car("Toyota", "Corola", 1555151);
            Car c4 = new Car("Toyota", "Corola", 328+151);
            Car c5 = new Car("Toyota", "Corola", 54845);



            //revisar si existen parqueos disponibles
         //   c1.ParqueosTotales = 5;

            SetCarOnParking(c1);
            SetCarOnParking(c2);
            SetCarOnParking(c3);
            SetCarOnParking(c4);
            SetCarOnParking(c5);
           

            //si existen parqueos disponibles entonces parquea el carro.

        }
       

    }
}
