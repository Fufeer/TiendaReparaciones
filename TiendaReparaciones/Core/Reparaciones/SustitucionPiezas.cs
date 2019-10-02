using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core.Reparaciones
{
    class SustitucionPiezas : Reparacion
    {

        //recibo un objeto aparato?
        public SustitucionPiezas (double horas, int precioHora, int numSerie)
            : base(horas, precioHora, numSerie)
        {

        }

        public override double calcularPrecio(int precioPiezas)
        {
            return base.calcularPrecio(precioPiezas) + precioHora/2*fragmentos;
        }

        public override string ToString()
        {
            return "Sustitucion de piezas.\n" + base.ToString();
        }
    }
}
