using System;

namespace ConexusHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Uzrakstiet funkciju, kas, saņemot veselo skaitļu masīvu, pārceļ visas nulles uz masīva beigām, saglabājot pārējo
            //skaitļu kārtību. Mēģiniet izmantot pēc iespējas mazāk papildus atmiņas.
            //Piemērs: [5, 0, 8, 3, 0] => [5, 8, 3, 0, 0]. 

            int[] intArr = new int[] { 1, 0, 0, 4, 6, 0, 0, 9, 8, 4, 2, 4, 5, 0 };

            Console.WriteLine("unsorted [{0}]", string.Join(", ", intArr));
            ArrayOperation.AllToRightMost(intArr, 0);
            Console.WriteLine("shoveZero[{0}]", string.Join(", ", intArr));

            //2. Ko var noskaidrot ar pārbaudi, ja x – vesels skaitlis: x & (x - 1) == 0 ?
            string question = "(x & (x - 1) == 0)  how can this be used?";
            string answer = "Will return True at (int)'x' equals all powers of '2', ignoring '-' sign," +

                "at x = 1 (1 & 0) resuts: 2^0 = 1 therefore True" +

                "at x = 0 (0 & -1) we also get True, assumption: " +
                "'-' in 'int' is stored at leftmost position. " +
                "As this operates at rightmost end of 'int', all relevant data looks the same as a case for: (0 & 1) or (1 & 0)";
            Console.WriteLine("(( 0 & -1 ) == ( 0 & 1 )) : " + ((0 & -1) == (0 & 1)));//true

            //3. Uzrakstiet funkciju, kas masīvam noskaidro mediānu (elements, kas sadala kopu divās vienādās daļās: skaitļi,
            //mazāki par mediānu, un skaitļi, lielāki par mediānu). 
            Console.WriteLine("median: " + Median.GetMedian(intArr));
        }
    }
}
