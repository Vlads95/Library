﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septembar_2015
{
    public class Sala
    {
        int broj;
        int kapacitet;
        Lokacija lokacija;
        Osoba osoba;
        public List<Kandidat> spisakKandidata;

        public Sala(int broj,
        int kapacitet,
        Lokacija lokacija,
        Osoba osoba               )
        {
            this.broj = broj;
            this.kapacitet = kapacitet;
            this.lokacija = lokacija;
            this.osoba = osoba;
            spisakKandidata = new List<Kandidat>();



        }

        public int Broj { get => broj; set => broj = value; }
        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        public Lokacija Lokacija { get => lokacija; set => lokacija = value; }
        public Osoba Osoba { get => osoba; set => osoba = value; }
        public List<Kandidat> SpisakKandidata { get => spisakKandidata; set => spisakKandidata = value; }





        /* U klasi Sala implementirati metodu UcitajSalu kojom se sa tastature učitava i vraća sala.
         * Metoda kao parametre prima prethodno kreiranu lokaciju i spisak neraspoređenih kandidata. */

        public Sala UcitajSalu(Lokacija l,  List<Kandidat> spisak  )

        {

            

            Console.WriteLine("Unesi broj sale  ");
            int brSale = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Kapacitet");
            int kapacitet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ime");
            string imeOL = Console.ReadLine();
            //osoba
            Console.WriteLine("Datum rodjenja ");
            DateTime d = Convert.ToDateTime(Console.ReadLine());

            Osoba o = new Osoba(imeOL, d);

            //lokacija
             Sala s = new Sala( brSale, kapacitet, l, o);


            return s;

        }



    }
}
