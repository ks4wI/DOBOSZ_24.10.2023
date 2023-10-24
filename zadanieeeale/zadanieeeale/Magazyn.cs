using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanieeeale;

namespace zadanieeeale
{
    internal class Magazyn
    {
        //kazda zmienna ma public zeby byla dostepna w calym programie
        public List<Produkt> produkty;
        public Adres adresMagazynu;

        //konstruktor 'Magazyn' przypisuje zmienne do pseudozmiennych
        public Magazyn(List<Produkt> produkty, Adres adresMagazynu)
        {
            this.produkty = new List<Produkt>();
            this.adresMagazynu = adresMagazynu;
        }
    }
}