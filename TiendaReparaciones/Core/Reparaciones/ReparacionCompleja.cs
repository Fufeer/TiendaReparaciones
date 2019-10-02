using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core.Reparaciones
{
    class ReparacionCompleja : Reparacion
    {
        //recibo un objeto aparato?
        public ReparacionCompleja(double horas, int precioHora, int numSerie)
            : base(horas, precioHora, numSerie)
        {

        }

        public override double calcularPrecio(int precioPiezas)
        {
            return base.calcularPrecio(precioPiezas) + precioHora / 2 * fragmentos * 1.25;
        }

        public override string ToString()
        {
            return "Reparacion compleja.\n" + base.ToString();
        }
    }
}
