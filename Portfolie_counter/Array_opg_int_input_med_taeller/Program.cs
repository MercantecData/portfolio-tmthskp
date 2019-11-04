using System;

namespace Array_opg_int_input_med_taeller_op_til_input
{
    class Program
    {
        /*
         Lav et hurtigt lille program hvor du implementerer en funktion
         der kan tage en integer som input, og returnere et array med tallene 
         fra 0 og op til det givne tal. (dvs. hvis man giver det 4, returnerer det {1,2,3,4}
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal:");
            InputWithCount();
        }

        static bool InputWithCount()
        {
            int i = 0;
            int indtast = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] nummer = new int[indtast];
            Console.WriteLine (0);
            while (i < indtast)
            {
                
            Console.WriteLine(nummer[i] = i += 1);
            }
            return InputWithCount();
        }



    }
}
