using System;
using System.Collections.Generic;
using System.Text;

namespace Obj_Cykel_Opg
{
    class TextBike
    {


        public void MyBikeText1(BikeShop bikeShop, int i)
        {
            Console.WriteLine("Nr " + (i + 1) + " Brand: " + bikeShop.bikes[i].BikeBrand);
        }

        public void MyBikeText2(BikeShop bikeShop, int i)
        {
            Console.WriteLine("Nr " + (i + 1) + " Brand: " + bikeShop.bikes[i].BikeBrand + "\nWheel Size: " + bikeShop.bikes[i].BikeWheelSize + " inches\n");
        }

        public void MyBikeText3(BikeShop bikeShop, int i)
        {
            Console.WriteLine("Wheel Size: " + bikeShop.bikes[i].BikeWheelSize + " inches\n" + "Nr " + (i + 1) + " Brand: " + bikeShop.bikes[i].BikeBrand + "\n");
        }
    }

}
