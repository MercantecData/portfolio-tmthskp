using System;

namespace Array_opg_int_input_med_taeller_op_til_input
{
    class Program
    {
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
