namespace GestionColegio.Domain.Entities
{
    public class Profesor : Usuario
    {
        public Profesor(string identificacion, string nombre, string apellido) 
            : base(identificacion, nombre, apellido)
        {

        }
    }
}
