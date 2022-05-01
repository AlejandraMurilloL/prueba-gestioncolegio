using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestionColegio.Domain.Entities
{
    public class Profesor : Usuario
    {
        public IList<Asignatura> Asignaturas { get; protected set; }

        public Profesor(string identificacion, string nombre, string apellido) 
            : base(identificacion, nombre, apellido)
        {
            Asignaturas = new List<Asignatura>();
        }
    }
}
