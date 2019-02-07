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

        public List<Marca> cars;

        //Singleton Method
        private ParkingLot(int TotalP)
        {
            this.cars = new List<Marca>();
            this.TotalParkingLots = TotalP;
        }

        public void Add(Marca mark)
        {
            this.cars.Add(mark);
        }

        public bool ParkCar(Marca car)
        {
            if (ParqueosUsados < TotalParkingLots)
            {
                this.cars.Add(car);
               Console.WriteLine($"Muy bien el auto {car.model} {car.marca} se ha estacionado. No nos hacemos responsables de robos.");
                return true;
            }
            else
                Console.WriteLine("No hay parqueos Disponibles.");
                return false;
        }

        public int GetAvailableParking()
        {
            return TotalParkingLots - ParqueosUsados;
        }

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
