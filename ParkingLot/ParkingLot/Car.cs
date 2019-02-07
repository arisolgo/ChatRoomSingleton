using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public string Model { get; set; }
        public string Marca { get; set; }
        public ParkingLot parkinglot { get; set; }
        public Car(string modelo, string marca)
        {
            this.parkinglot = ParkingLot.GetParkingLot(5);
            this.Model = modelo;
            this.Marca = marca;
           
        }
       
    }
}
