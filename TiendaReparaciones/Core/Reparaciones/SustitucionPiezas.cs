using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core.Reparaciones
{
    class SustitucionPiezas : Reparacion
    {
        protected SustitucionPiezas (int horas)
            : base(horas)
        {

        }

        public override double calcularPrecio(int precioPiezas, Aparato aparato)
        {
            return base.calcularPrecio(precioPiezas, aparato) + aparato.precioH/2*fragmentos;
        }
    }
}
