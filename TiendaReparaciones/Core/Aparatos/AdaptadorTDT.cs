using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    class AdaptadorTDT : Aparato
    {
        public const int precioH = 5;

        public AdaptadorTDT(int numSerie, string modelo, int tiempo)
            : base(numSerie, modelo, precioH)
        {
            this.tiempo = tiempo;
        }

        public int tiempo
        {
            get; set;
        }

        public override string ToString()
        {
            return "ADAPTADOR TDT\n" + base.ToString() + "\Tiempo que graba: " + tiempo;
        }
    }
}
