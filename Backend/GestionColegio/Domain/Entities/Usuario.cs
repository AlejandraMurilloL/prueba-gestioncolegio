using System;
using System.Collections.Generic;
using System.Text;

namespace GestionColegio.Domain.Entities
{
    public abstract class Usuario : BaseEntity
    {
        public string Identificacion { get; protected set; }
        public string Nombre { get; protected set; }
        public string Apellido { get; protected set; }
        public int? Edad { get; protected set; }
        public string Direccion { get; protected set; }
        public string Telefono { get; protected set; }

        public Usuario(string identificacion, string nombre, string apellido)
        {
            ConIdentificacion(identificacion);
            ConNombreCompleto(nombre, apellido);
        }

        internal Usuario ConNombreCompleto(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

            return this;
        }

        internal Usuario ConIdentificacion(string identificacion)
        {
            Identificacion = identificacion;

            return this;
        }

        internal Usuario Actualizar(int edad, string direccion, string telefono)
        {
            ConEdad(edad);
            ConDireccion(direccion);
            ConTelefono(telefono);

            return this;
        }

        internal Usuario ConEdad(int edad)
        {
            Edad = edad;

            return this;
        }

        internal Usuario ConDireccion(string direccion)
        {
            Direccion = direccion;

            return this;
        }

        internal Usuario ConTelefono(string telefono)
        {
            Telefono = telefono;

            return this;
        }
    }
}
