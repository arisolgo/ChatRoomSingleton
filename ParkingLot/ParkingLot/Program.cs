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
            
            Car c1 = new Car("Toyota", "Camry");
            

            //revisar si existen parqueos disponibles
            if (c1.parkinglot.GetAvailableParking() > 0 )
            {
                c1.parkinglot.ParkCar(new Marca() { marca = c1.Marca, model = c1.Model });
            }
            //si existen parqueos disponibles entonces parquea el carro.

           
           

            
        }

      
    }
}
