using System;
using System.Collections.Generic;
using System.Text;

namespace Obj_Cykel_Opg
{
    class Bike
    {
        //Parameters for Bike data
        public int Amount;
        public string BikeBrand;
        public string BikeColor;
        public double BikeWheelSize;
        

        //constructor of Bike by use of parameters
        public Bike(int Amount, string BikeBrand, string BikeColor,  double BikeWheelSize)
        {
            this.Amount = Amount;
            this.BikeBrand = BikeBrand;
            this.BikeColor = BikeColor;
            this.BikeWheelSize = BikeWheelSize;
        }

    }
}
