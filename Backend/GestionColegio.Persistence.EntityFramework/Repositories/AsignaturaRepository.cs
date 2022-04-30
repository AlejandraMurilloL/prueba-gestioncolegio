using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using GestionColegio.Persistence.EntityFramework.Context;

namespace GestionColegio.Persistence.EntityFramework.Repositories
{
    public class AsignaturaRepository : Repository<Asignatura>, IAsignaturaRepository
    {
        public AsignaturaRepository(GestionColegioDbContext context) : base(context)
        {

        }
    }
}
