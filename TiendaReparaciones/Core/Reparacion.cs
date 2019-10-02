using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    using Core.Reparaciones;
    public abstract class Reparacion
    {
        protected Reparacion(double horas, Aparato aparato)
        {
            double aux = horas;
            while (aux > 0)
            {
                aux -= 0.5;
                fragmentos++;
            }
            this.horas = horas;
            precioHora = aparato.precioHora;
            numSerie = aparato.numSerie;
        }

        public static Reparacion Crea(double horas, Aparato aparato)
        {
            Reparacion toret = null;

            if (horas <= 1)
            {
                toret = new SustitucionPiezas(horas, aparato);
            }
            else
            {
                toret = new ReparacionCompleja(horas,aparato);
            }

            return toret;
        }

        public double horas
        {
            get; set;
        }

        public double fragmentos
        {
            get; set;
        }

        public int precioHora
        {
            get; set;
        }

        public int numSerie
        {
            get; set;
        }

        public virtual double calcularPrecio(int precioPiezas)
        {
            return 10 + precioPiezas;
        }


        public override string ToString()
        {
            return "Reparacion de aparato con numero de serie " + numSerie
                + "\nNumero de horas trabajadas: " + horas + " con un precio de " + precioHora + " euros la hora.";
        }

    }
}
