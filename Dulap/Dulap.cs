using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulap
{
    class Dulap
    {
        private double lungime;
        private double latime;
        private double inaltime;

        public double Lungime
        {
            get { return lungime; }
            set { lungime = value; }
        }
        public double Latime
        {
            get { return latime; }
            set { latime = value; } 
        }
        public double Inaltime
        {
            get { return inaltime; }
            set { inaltime = value; }

        }

        public Dulap(double lungime, double latime, double inaltime)
        {
            Lungime =lungime;
            Latime = latime;
            Inaltime = inaltime;
        }

      // metoda de calculare a volumului

        public double CalcVolum(double lungime , double latime , double inaltime)
        {
            double volum = lungime * latime * inaltime;

            return volum;
        }
        public void Text(double lungime , double latime , double inaltime , double volum)
        {
            Console.WriteLine($" Dulapul are lungimea =  {lungime} , latimea = {latime} , inaltimea = {inaltime} si volumul  = {volum}");
        }
    }
}
