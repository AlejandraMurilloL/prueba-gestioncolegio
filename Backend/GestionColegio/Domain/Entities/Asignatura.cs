using System.Data;

namespace GestionColegio.Domain.Entities
{
    public class Asignatura : BaseEntity
    {
        public int Codigo { get; protected set; }
        public string Nombre { get; protected set; }
        public Profesor Profesor { get; protected set; }
        public int? ProfesorId { get; protected set; }

        internal Asignatura Actualizar(int codigo, string nombre)
        {
            ConCodigo(codigo);
            ConNombre(nombre);
            return this;
        }

        internal Asignatura ConCodigo(int codigo)
        {
            Codigo = codigo;
            return this;
        }

        internal Asignatura ConNombre(string nombre)
        {
            Nombre = nombre;
            return this;
        }

        internal Asignatura ConProfesor(Profesor profesor)
        {
            if (ProfesorId.HasValue && ProfesorId == profesor.Id)
            {
                throw new DataException("La asignatura ya ha sido asignada al profesor indicado");
            }

            Profesor = profesor;
            ProfesorId = profesor?.Id;

            return this;
        }

    }
}
