using CesiWebApp_Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CesiWebApp.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext()
        {
        }

        public DefaultContext(DbContextOptions dbContext) : base(dbContext)
        {
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
