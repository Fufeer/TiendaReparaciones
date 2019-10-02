using System;

namespace TiendaReparaciones
{
    using Core;
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Radio(10, "sony", "am");
            Console.WriteLine(r);
        }
    }
}
