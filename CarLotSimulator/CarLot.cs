using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public List<CarLotSimulator.Car> CarList { get; set; }

        public CarLot(List<CarLotSimulator.Car> carList)
        {
            CarList = carList;
        }
    }
}
