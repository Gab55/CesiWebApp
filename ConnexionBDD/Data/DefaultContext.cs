using CesiWebApp_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;


namespace ConnexionBDD.Data
{
    class DefaultContext : DbContext
    {
        protected DefaultContext()
        {
        }

        protected DefaultContext(DbContext dbContext)
        {
        }

        public DbSet<Utilisateur> utilisateurs { get; set; }
    }
}
