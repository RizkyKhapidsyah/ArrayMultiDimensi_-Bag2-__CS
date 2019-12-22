using System;

namespace ArrayMultiDimensi__Bag2___CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] B = { { 1, 3, 5, 7, 9 }, { 2, 4, 6, 8, 0 }, { 1, 4, 7, 0, 2 } };
            int[,,] C = { { { 1, 2, 4, 5, 7, 8 }, { 3, 4, 6, 7, 9, 0 } }, { { 4, 5, 7, 8, 0, 1 }, { 1, 0, 2, 9, 3, 8 } } };

            Console.WriteLine("Nilai Data A Yang Dipilih : {0} ", A[2]);                    //Akan Menampilkan Angka '3'
            Console.WriteLine("Nilai Data B Yang Dipilih : {0} ", B[1, 3]);                 //Akan Menampilkan Angka '8'
            Console.WriteLine("Nilai Data C Yang Dipilih : {0} ", C[0, 1, 4]);              //Akan Menampilkan Angka '9'
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Data A Merupakan Array " + A.Rank + " Dimensi");
            Console.WriteLine("Data B Merupakan Array " + B.Rank + " Dimensi");
            Console.WriteLine("Data C Merupakan Array " + C.Rank + " Dimensi");
            Console.WriteLine("---------------------------------");
            




            Console.ReadLine();
        }


    }
}
