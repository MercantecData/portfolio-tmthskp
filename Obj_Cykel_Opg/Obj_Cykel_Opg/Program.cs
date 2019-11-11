using System;

namespace Obj_Cykel_Opg
{
    /*
        1. Lav et nyt projekt, og læg i portfolio. 
        2. I dette projekt skal i lave en klasse til cykler. Der skal være class variabler til mærke, hjulstørrelse, farve, mm.
        3. Lav en klasse for cykelbutik. Denne skal kunne indeholde et variabelt antal cykel-objekter.
        4. Lav en funktion i butik-klassen. Denne skal kunne returnere alle cyklers mærke (dvs. ikke selve cykel objektet) som et string-array.
        5. Lav to funktioner i butik-klassen, som begge tager imod en double. Den ene skal returnere alle cykler (som et Cykel array) med hjulstørrelse under det givne, og den anden skal returnere alle cykler med hjulstørrelse over det givne.
        6. Lav en klasse for cykel koncernen (dvs. den som ejer alle butikkerne).
        7. Lav en funktion i koncern klassen som svarer på hvor mange røde cykler der er i hele koncernen.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BikeShop \nCurrent bikes are in our inventory\n");
            BikeShop bikeShop = new BikeShop();
            BikeConcern bikeConcern = new BikeConcern();

            //overwiew of current bikess
            Console.WriteLine(bikeShop.bikes[0].BikeBrand + " Color " + bikeShop.bikes[0].BikeColor + " Wheel size " + bikeShop.bikes[0].BikeWheelSize + " Amount in inventory " + bikeShop.bikes[0].Amount);
            Console.WriteLine(bikeShop.bikes[1].BikeBrand + " Color " + bikeShop.bikes[1].BikeColor + " Wheel size " + bikeShop.bikes[1].BikeWheelSize + " Amount in inventory " + bikeShop.bikes[1].Amount);
            Console.WriteLine(bikeShop.bikes[2].BikeBrand + " Color " + bikeShop.bikes[2].BikeColor + " Wheel size " + bikeShop.bikes[2].BikeWheelSize + " Amount in inventory " + bikeShop.bikes[2].Amount);

            Console.WriteLine("\nThese are our Bike Brands:");
            bikeShop.MyBikeBrands();

            Console.WriteLine("\nOur bikes got these wheel sizes:");
            bikeShop.MyBrandBikeWheelSize();

            Console.WriteLine("\nIf you prefer it like this insted:");
            bikeShop.MyBikeWheelSizeBrand();

            Console.WriteLine("\nThere are this many red bikes in the shop:");
            bikeConcern.BikesRed();


        }

    }
}
