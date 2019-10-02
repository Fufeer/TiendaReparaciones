using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    public abstract class Reparacion
    {

        protected Reparacion(int horas)
        {
            double aux = horas;
            while (aux > 0)
            {
                aux -= 0.5;
                fragmentos++;
            }
        }

        public double horas
        {
            get; set;
        }

        public double fragmentos
        {
            get; set;
        }

        public virtual double calcularPrecio(int precioPiezas, Aparato aparato)
        {
            return 10 + precioPiezas;
        }

    }
}
