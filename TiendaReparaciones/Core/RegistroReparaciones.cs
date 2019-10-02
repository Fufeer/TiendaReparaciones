using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Collections;
using System.Xml.Linq;

namespace TiendaReparaciones.Core
{
    public class RegistroReparaciones : ICollection<Reparacion>
    {
        private List<Reparacion> reparaciones;

        public const string ArchivoXml = "reparaciones.xml";
        public const string EtqReparaciones = "reparaciones";
        public const string EtqReparacion = "reparacion";
        public const string EtqHoras = "horas";
        public const string EtqPrecioHora = "precioHora";
        public const string EtqNumSerie = "numSerie";

        public RegistroReparaciones()
        {
            this.reparaciones = new List<Reparacion>();
        }

        public RegistroReparaciones(IEnumerable<Reparacion> reparaciones)
            : this()
        {
            this.reparaciones.AddRange(reparaciones);
        }

        public void Add(Reparacion r)
        {
            this.reparaciones.Add(r);
        }

    
		public bool Remove(Reparacion r)
        {
            return this.reparaciones.Remove(r);
        }

        /// <summary>
        /// Elimina un viaje en la pos. i.
        /// </summary>
        /// <param name="i">La pos. a eliminar</param>
		public void RemoveAt(int i)
        {
            this.reparaciones.RemoveAt(i);
        }


		public void AddRange(IEnumerable<Reparacion> rs)
        {
            this.reparaciones.AddRange(rs);
        }

		public int Count
        {
            get { return this.reparaciones.Count; }
        }

		public bool IsReadOnly
        {
            get { return false; }
        }


		public void Clear()
        {
            this.reparaciones.Clear();
        }

		public bool Contains(Reparacion r)
        {
            return this.reparaciones.Contains(r);
        }


		public void CopyTo(Reparacion[] r, int i)
        {
            this.reparaciones.CopyTo(r, i);
        }

        IEnumerator<Reparacion> IEnumerable<Reparacion>.GetEnumerator()
        {
            foreach (var r in this.reparaciones)
            {
                yield return r;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var r in this.reparaciones)
            {
                yield return r;
            }
        }

        
        public Reparacion this[int i]
        {
            get { return this.reparaciones[i]; }
            set { this.reparaciones[i] = value; }
        }

		public override string ToString()
        {
            var toret = new StringBuilder();

            foreach (Reparacion r in this.reparaciones)
            {
                toret.AppendLine(r.ToString());
            }

            return toret.ToString();
        }

        /// <summary>
        /// Guarda la lista de viajes como xml.
        /// </summary>
        public void GuardaXml()
        {
            this.GuardaXml(ArchivoXml);
        }

        /// <summary>
        /// Guarda la lista de viajes como XML.
        /// <param name="nf">El nombre del archivo.</param>
        /// </summary>
        public void GuardaXml(string nf)
        {
            var doc = new XDocument();
            var root = new XElement(EtqReparaciones);

            foreach (Reparacion reparacion in this.reparaciones)
            {
                root.Add(
                    new XElement(EtqReparacion,
                            new XAttribute(EtqHoras, reparacion.horas),
                            new XAttribute(EtqPrecioHora, reparacion.precioHora),
                            new XAttribute(EtqNumSerie, reparacion.numSerie)));
            }

            doc.Add(root);
            doc.Save(nf);
        }

        /// <summary>
        /// Recupera los viajes desde un archivo XML.
        /// </summary>
        /// <returns>Un <see cref="RegistroViajes"/> con los
        /// <see cref="Viaje"/>'s.</returns>
        /// <param name="f">El nombre del archivo.</param>
		public static RegistroReparaciones RecuperaXml(string f)
        {
            var toret = new RegistroReparaciones();

            try
            {
                var doc = XDocument.Load(f);

                if (doc.Root != null
                  && doc.Root.Name == EtqReparaciones)
                {
                    var reparaciones = doc.Root.Elements(EtqReparacion);

                    foreach (XElement reparacionXml in reparaciones)
                    {
                        toret.Add(Reparacion.Crea(
                            (double)reparacionXml.Attribute(EtqHoras),
                            (int)reparacionXml.Attribute(EtqPrecioHora),
                            (int)reparacionXml.Element(EtqNumSerie)));
                    }
                }
            }
            catch (XmlException)
            {
                toret.Clear();
            }
            catch (IOException)
            {
                toret.Clear();
            }

            return toret;
        }

        /// <summary>
        /// Crea un registro de viajes con la lista de viajes recuperada
        /// del archivo por defecto.
        /// </summary>
        /// <returns>Un <see cref="RegistroViajes"/>.</returns>
		public static RegistroReparaciones RecuperaXml()
        {
            return RecuperaXml(ArchivoXml);
        }



    }
}
