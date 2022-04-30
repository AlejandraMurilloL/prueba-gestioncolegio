namespace GestionColegio.Domain.Entities
{
    public class Asignatura : BaseEntity
    {
        public int Codigo { get; protected set; }
        public string Nombre { get; protected set; }
    }
}
