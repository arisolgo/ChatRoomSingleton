using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
       // public int ParqueosTotales;
        public string Model { get; set; }
        public string Marca { get; set; }
        public ParkingLot parkinglot { get; set; }

       
        public Car(string modelo, string marca, int TotalPark)
        {
            this.parkinglot = ParkingLot.GetParkingLot(TotalPark);
            this.Model = modelo;
            this.Marca = marca;
           
        }
       
    }
}
