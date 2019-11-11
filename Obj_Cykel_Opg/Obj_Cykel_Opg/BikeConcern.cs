using System;
using System.Collections.Generic;
using System.Text;

namespace Obj_Cykel_Opg
{
    class BikeConcern
    {
        BikeShop bikeShop = new BikeShop();

        //overwiew of current red bikes
        public void BikesRed() 
        { 
        Console.WriteLine("Color " + bikeShop.bikes[0].BikeColor + "There are " + bikeShop.bikes[0].Amount + " in The inventory ");
        }
    }
}
