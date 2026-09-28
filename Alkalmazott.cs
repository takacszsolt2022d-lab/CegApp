using System;
using System.Collections.Generic;
using System.Text;

namespace CegApp
{
    internal class Alkalmazott
    {
        public string Nev { get; set; }

        protected int alapber;


        public Alkalmazott(string nev, int alapber)
        {
            Nev = nev;
            this.alapber = alapber;
        }

        public virtual int FizetesSzamitas()
        {
            return alapber;
        }

        public override string ToString()
        {
            return $"{Nev} - Fizetés: {FizetesSzamitas()}";
        }
    }
}
