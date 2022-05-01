using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using GestionColegio.Persistence.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GestionColegio.Persistence.EntityFramework.Repositories
{
    class ProfesorRepository : Repository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(GestionColegioDbContext context) : base(context)
        {
        }

        public new async Task<Profesor> GetByIdAsync(object id)
        {
            return await _dbSet.Include(x => x.Asignaturas)
                .FirstOrDefaultAsync(x => x.Id == (int)id)
                .ConfigureAwait(false);
        }
    }
}
