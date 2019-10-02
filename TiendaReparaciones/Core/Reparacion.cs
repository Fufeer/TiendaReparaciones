using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    public abstract class Reparacion
    {

        protected Reparacion(int horas)
        {

        }

        public int horas
        {
            get; set;
        }

        public virtual int calcularPrecio()
        {

        }

    }
}
