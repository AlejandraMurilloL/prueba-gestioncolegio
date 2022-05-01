using System;
using System.Collections.Generic;
using System.Text;

namespace GestionColegio.Domain.Entities
{
    public class Estudiante : Usuario
    {
        public Estudiante(string identificacion, string nombre, string apellido)
            : base(identificacion, nombre, apellido)
        {

        }
    }
}
