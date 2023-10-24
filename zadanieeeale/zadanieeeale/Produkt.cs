using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieeeale
{
    internal class Produkt
    {
        //kazda zmienna ma public zeby byla dostepna w calym programie
        public string nazwaProducenta;
        public string nazwaProduktu;
        public string kategoria;
        public string kodProduktu;
        public int cena;
        public string opis;

        //konstruktor 'Produkt' przypisuje zmienne do pseudozmiennych
        public Produkt(string nazwaProducenta, string nazwaProduktu, string kategoria, string kodProduktu, int cena, string opis)
        {
            this.nazwaProducenta = nazwaProducenta;
            this.nazwaProduktu = nazwaProduktu;
            this.kategoria = kategoria;
            this.kodProduktu = kodProduktu;
            this.cena = cena;
            this.opis = opis;
        }
    }
}