using System;

namespace Objekt_beskrivelse_opg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coffeecup Description
            CoffeeCup myCup = new CoffeeCup();
            myCup.Color = "Gray";
            myCup.Surface = "Smooth";
            myCup.Material = "Steel";
            myCup.TopMaterial = "Plastic";
            myCup.LockMaterial = "Plastic";

            Console.WriteLine(myCup.CupDescription());
            Console.WriteLine("");

            
            CupUsage myCupUsage = new CupUsage();
            myCupUsage.Contain = "Coffee";
            myCupUsage.Drink = "Drink from a drink spout";
            myCupUsage.Thermo = "Can keep the drink varm";
            myCupUsage.Open = " The Top can Open";
            myCupUsage.Close = " The Top can Close";

            Console.WriteLine(myCupUsage.CupUsage1());
            Console.WriteLine("");


            // Window Description
            Window myWindow = new Window();
            myWindow.Transperency = "Transperant";
            myWindow.Surface = "Smooth Surface";
            myWindow.Shape = "Round";
            myWindow.Reflective = " Reflective";
            myWindow.Attached = " To a wall";
             
            Console.WriteLine(myWindow.MyWindow());
            Console.WriteLine("");


            WindowUsage myWindowUsage = new WindowUsage();
            myWindowUsage.Smash = "Smashed!!";
            myWindowUsage.SeeThrough = "See Through";
            myWindowUsage.Iluminate = "Light";
            myWindowUsage.HeatCold = " Heat and Cold";
            myWindowUsage.Polish = " Polish";

            Console.WriteLine(myWindowUsage.MyWindowUsage());
            Console.WriteLine("");


            // Sign Description
            SignDescription signDescription = new SignDescription();
            signDescription.Stability = "Stable";
            signDescription.Color = "Red";
            signDescription.Text = "Some Text";
            signDescription.Material = "Steel";
            signDescription.Standing = "It is standing";

            Console.WriteLine(signDescription.MySign());
            Console.WriteLine("");


            SignUsage signUsage = new SignUsage();
            signUsage.Look = "Look";
            signUsage.Read = "Read";
            signUsage.Sit = "Sit";
            signUsage.Info = "Information";
            signUsage.Smash = "Smash!!";

            Console.WriteLine(signUsage.MySignUsage());
            Console.WriteLine("");


            // Door Description
            DoorDescription doorDescription = new DoorDescription();
            doorDescription.Surface = "Surface";
            doorDescription.Handle = "Handle";
            doorDescription.KeyHole = "KeyHole";
            doorDescription.Color = "Color";
            doorDescription.Attached = "Attached";

            Console.WriteLine(doorDescription.MyDoorDescription());
            Console.WriteLine("");


            DoorUsage doorUsage = new DoorUsage();
            doorUsage.Open = "Open";
            doorUsage.Close = "Close";
            doorUsage.Lock = "Lock";
            doorUsage.OpenLock = "Open Lock";
            doorUsage.Smash = "Smashed!!";

            Console.WriteLine(doorUsage.MyDoorUsage());
            Console.WriteLine("");


            // ElevatorLift Description
            ElevatorLiftDesription elevatorLiftDescription = new ElevatorLiftDesription();
            elevatorLiftDescription.Surface = "Surface";
            elevatorLiftDescription.Display = "Display";
            elevatorLiftDescription.Button = "Button";
            elevatorLiftDescription.Doors = "Doors";
            elevatorLiftDescription.Metal = "Metal";

            Console.WriteLine(elevatorLiftDescription.MyElevatorLiftDescription());
            Console.WriteLine("");


            ElevatorLiftUsage elevatorLiftUsage = new ElevatorLiftUsage();
            elevatorLiftUsage.Contain = "Contain";
            elevatorLiftUsage.CanOpen = "Can Open";
            elevatorLiftUsage.Transport = "Transport";
            elevatorLiftUsage.UpDown = "Up and down";
            elevatorLiftUsage.Input = "Input";

            Console.WriteLine(elevatorLiftUsage.MyElevatorLiftUsage());
            Console.WriteLine("");
        }
       
    }
}

