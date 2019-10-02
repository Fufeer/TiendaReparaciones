using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    class Televisor : Aparato
    {
        public const int precioH = 10;

        public Televisor(int numSerie, string modelo, int pulgadas)
            :base(numSerie, modelo, precioH)
        {
            this.pulgadas = pulgadas;
        }

        public int pulgadas
        {
            get; set;
        }

        public override string ToString()
        {
            return "TELEVISOR\n" + base.ToString() + "\nPulgadas: " + pulgadas;
        }

    }
}
