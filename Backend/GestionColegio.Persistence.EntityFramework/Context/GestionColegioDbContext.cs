using GestionColegio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GestionColegio.Persistence.EntityFramework.Context
{
    public class GestionColegioDbContext : DbContext
    {
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        public GestionColegioDbContext
        (DbContextOptions<GestionColegioDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
