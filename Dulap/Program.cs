using System;
using System.Globalization;

namespace Dulap
{


    class program
    {
        static void Main(string[] args)
        {
            string afisare1 = " Tastati lungimea = ";

            Console.WriteLine(afisare1);
            double lungime = double.Parse(Console.ReadLine());

            string afisare2 = " Tastati latimea = ";
            Console.WriteLine(afisare2);
            double latime = double.Parse(Console.ReadLine());

            string afisare3 = " Tastati inaltimea = ";
            Console.WriteLine(afisare3);
            double inaltime = double.Parse(Console.ReadLine());

            Dulap dulap = new Dulap(lungime, latime, inaltime);

          dulap.CalcVolum(lungime,latime,inaltime);

            dulap.Text(lungime,latime,inaltime,dulap.CalcVolum(lungime, latime, inaltime));

            Dulap dulap2 = dulap;

            afisare1 = " Tastati lungimea = ";

            Console.WriteLine(afisare1);
            double lungime1 = double.Parse(Console.ReadLine());

            afisare2 = " Tastati latimea = ";
            Console.WriteLine(afisare2);
            double latime1 = double.Parse(Console.ReadLine());

           afisare3 = " Tastati inaltimea = ";
            Console.WriteLine(afisare3);
            double inaltime1 = double.Parse(Console.ReadLine());


            dulap2.CalcVolum(lungime1, latime1, inaltime1);

            dulap2.Text(lungime1, latime1, inaltime1, dulap.CalcVolum(lungime1, latime1, inaltime1));


        }



    }
}
