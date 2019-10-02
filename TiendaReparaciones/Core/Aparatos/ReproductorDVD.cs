using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaReparaciones.Core
{
    class ReproductorDVD : Aparato
    {
        public const int precioH = 10;

        public ReproductorDVD(int numSerie, string modelo, bool blueray)
            : base(numSerie, modelo, precioH)
        {
            this.blueray = blueray;
            this.graba = false;
            this.tiempo = 0;
        }

        public ReproductorDVD(int numSerie, string modelo, bool blueray, int tiempo)
            : base(numSerie, modelo, precioH)
        {
            this.blueray = blueray;
            this.graba = true;
            this.tiempo = tiempo;
        }

        public bool blueray
        {
            get; set;
        }
        public bool graba
        {
            get; set;
        }

        public int tiempo
        {
            get; set;
        }

        public override string ToString()
        {
            return "REPRODUCTOR DVD\n" + base.ToString() + "\nReproduce Blue-Ray: " + blueray
                +"\nGraba: " + graba + "\nTiempo: " + tiempo;
        }
    }
}
