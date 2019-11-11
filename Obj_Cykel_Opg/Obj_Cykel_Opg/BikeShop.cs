using System;
using System.Collections.Generic;
using System.Text;

namespace Obj_Cykel_Opg
{
    class BikeShop
    {
        //convert classes to objects
        public List<Bike> bikes = new List<Bike>();
        TextBike textBike = new TextBike();

        /********* Bike Data Commit *********/
        public BikeShop()
        {
            Bike bike1 = new Bike(3, "A Good Bike ", "Red ", 26.3);
            Bike bike2 = new Bike(2, "A Great Bike ", "Blue ", 28.2);
            Bike bike3 = new Bike(4, "A Not so Good Bike ", "Green ", 24.5);

            bikes.Add(bike1);
            bikes.Add(bike2);
            bikes.Add(bike3);
        }

        //brands
        public void MyBikeBrands() 
        { 
            for (int i = 0; i<bikes.Count; i++) // For each element in the list print from method MyBurrowText2
            {          
                textBike.MyBikeText1(this, i);         
            }
        }

        //Wheel size and brand
        public void MyBrandBikeWheelSize()
        {
            for (int i = 0; i < bikes.Count; i++) // For each element in the list print from method MyBurrowText2
            { 
                textBike.MyBikeText2(this, i);
            }
        }

        public void MyBikeWheelSizeBrand()
        {
            for (int i = 0; i < bikes.Count; i++) // For each element in the list print from method MyBurrowText2
            {
                
                textBike.MyBikeText3(this, i);
            }
        }
    }
}
