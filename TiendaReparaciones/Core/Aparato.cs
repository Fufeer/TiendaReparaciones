using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    public abstract class Aparato
    {
        protected Aparato(int numSerie, string modelo, int precioHora)
        {
            this.numSerie = numSerie;
            this.modelo = modelo;
            this.precioHora = precioHora;
        }

        public int numSerie
        {
            get; set;
        }

        public string modelo
        {
            get; set;
        }

        public virtual int precioHora
        {
            get; set;
        }

        public override string ToString()
        {
            return "RADIO\nNum Serie: " + numSerie + "\nModelo: " + modelo + "\nPrecio por hora: " + precioHora;
        }

        //CREAR LUEGO

    }
}
