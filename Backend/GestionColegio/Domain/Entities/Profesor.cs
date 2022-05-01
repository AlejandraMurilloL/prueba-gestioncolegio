using System;
using System.Collections.Generic;
using System.Text;

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
