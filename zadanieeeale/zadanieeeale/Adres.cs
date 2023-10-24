using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieeeale
{
    internal class Adres
    {
        //kazda zmienna ma public zeby byla dostepna w calym programie
        public string ulica;
        public string kodPocztowy;
        public string miejscowosc;
        public string numerPosesji;
        public string numerLokalu;

        //konstruktor 'Adres' przypisuje zmienne do pseudozmiennych
        public Adres(string ulica, string kodPocztowy, string miejscowosc, string numerPosesji, string numerLokalu)
        {
            this.ulica = ulica;
            this.kodPocztowy = kodPocztowy;
            this.miejscowosc = miejscowosc;
            this.numerPosesji = numerPosesji;
            this.numerLokalu = numerLokalu;
        }
    }
}