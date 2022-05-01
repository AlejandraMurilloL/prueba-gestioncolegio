using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using GestionColegio.Persistence.EntityFramework.Context;

namespace GestionColegio.Persistence.EntityFramework.Repositories
{
    class ProfesorRepository : Repository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(GestionColegioDbContext context) : base(context)
        {

        }
    }
}
