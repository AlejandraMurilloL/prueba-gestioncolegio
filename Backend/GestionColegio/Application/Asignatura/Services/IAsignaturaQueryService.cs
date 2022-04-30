using GestionColegio.Application.Asignatura.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignatura.Services
{
    public interface IAsignaturaQueryService
    {
        Task<IEnumerable<AsignaturaDto>> GetAll();
    }
}
