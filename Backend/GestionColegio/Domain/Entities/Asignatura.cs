namespace GestionColegio.Domain.Entities
{
    public class Asignatura : BaseEntity
    {
        public int Codigo { get; protected set; }
        public string Nombre { get; protected set; }

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

    }
}
