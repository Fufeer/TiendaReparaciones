using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    public abstract class Aparato
    {
        protected Aparato(int numSerie, string modelo, int precioH)
        {
            this.numSerie = numSerie;
            this.modelo = modelo;
            this.precioH = precioH;
        }

        public int numSerie
        {
            get; set;
        }

        public string modelo
        {
            get; set;
        }

        public int precioH
        {
            get; set;
        }

        public override string ToString()
        {
            return "RADIO\nNum Serie: " + numSerie + "\nModelo: " + modelo + "\nPrecio por hora: " + precioH;
        }

        //CREAR LUEGO

    }
}
