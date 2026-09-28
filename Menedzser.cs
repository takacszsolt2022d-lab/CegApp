using System;
using System.Collections.Generic;
using System.Text;

namespace CegApp
{
    internal class Menedzser : Alkalmazott
    {
      public int Bonusz { get; set; }

        public Menedzser(string nev, int alapber, int bonusz) : base(nev, alapber)
        {
            Bonusz = bonusz;
        }

        public override int FizetesSzamitas()
        {
            return base.FizetesSzamitas() + Bonusz;
        }
    }
}
