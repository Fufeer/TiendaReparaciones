using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    class Radio : Aparato
    {
        public const int precioH = 5;

        public Radio(int numSerie, string modelo, string bandas)
            :base(numSerie, modelo, precioH)
        {
            this.bandas = bandas;
        }

        public string bandas
        {
            get; set;
        }

        public override string ToString()
        {
            return base.ToString() + "\nBandas: " + this.bandas;
            
        }
    }
}
