using System;

namespace TiendaReparaciones
{
    using Core;
    using Core.Reparaciones;
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Radio(10, "sony", "am");
            var tele = new Televisor(1234, "LG", 52);
            var reparacion1 = Reparacion.Crea(1.5, tele);
            Console.WriteLine(r);
            Console.WriteLine(tele);
            Console.WriteLine(reparacion1);
            Console.WriteLine(reparacion1.calcularPrecio(100));

        }
    }
}
