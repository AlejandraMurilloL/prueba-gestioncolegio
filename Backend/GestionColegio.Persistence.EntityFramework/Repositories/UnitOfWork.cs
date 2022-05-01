using GestionColegio.Domain.Interfaces;
using GestionColegio.Persistence.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestionColegio.Persistence.EntityFramework.Repositories
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly GestionColegioDbContext _context;

        public IAsignaturaRepository AsignaturaRepository { get; private set; }
        public IProfesorRepository ProfesorRepository { get; private set; }


        public UnitOfWork(GestionColegioDbContext context)
        {
            _context = context;

            AsignaturaRepository = new AsignaturaRepository(_context);
            ProfesorRepository = new ProfesorRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }
    }
}
