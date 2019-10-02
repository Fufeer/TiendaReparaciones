using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    using Core.Reparaciones;
    public abstract class Reparacion
    {
        protected Reparacion(double horas, int precioHora, int numSerie)
        {
            double aux = horas;
            while (aux > 0)
            {
                aux -= 0.5;
                fragmentos++;
            }
            this.horas = horas;
            this.precioHora = precioHora;
            this.numSerie = numSerie;
        }

        public static Reparacion Crea(double horas, int precioHora, int numSerie)
        {
            Reparacion toret = null;

            if (horas <= 1)
            {
                toret = new SustitucionPiezas(horas, precioHora, numSerie);
            }
            else
            {
                toret = new ReparacionCompleja(horas, precioHora, numSerie);
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
