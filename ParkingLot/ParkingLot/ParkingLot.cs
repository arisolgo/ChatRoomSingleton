using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        private static ParkingLot sharedinstance;

        public int TotalParkingLots{ get; }
        public int ParqueosUsados
        {
            get
            {
                return this.cars.Count;
            }
                
        }

        public List<Car> cars;

       
        private ParkingLot(int TotalP)
        {
            this.cars = new List<Car>();
            this.TotalParkingLots = TotalP;
        }

        public void Add(Car car)
        {
            this.cars.Add(car);
        }

        public bool ParkCar(Car car)
        {
            if (ParqueosUsados < TotalParkingLots)
            {
                this.cars.Add(car);
               Console.WriteLine($"Muy bien el auto {car.Model} {car.Marca} se ha estacionado. No nos hacemos responsables de robos.");
                return true;
            }
            else if(ParqueosUsados > TotalParkingLots)
                Console.WriteLine("No hay parqueos Disponibles.");
                return false;
        }

        public int GetAvailableParking()
        {
            return TotalParkingLots - ParqueosUsados;
        }

        //Singleton Method
        public static ParkingLot GetParkingLot(int TotalParking)
        {
            if(sharedinstance == null)
            {
                sharedinstance = new ParkingLot(TotalParking);
            }
  
            return sharedinstance;
        }





    }
}
