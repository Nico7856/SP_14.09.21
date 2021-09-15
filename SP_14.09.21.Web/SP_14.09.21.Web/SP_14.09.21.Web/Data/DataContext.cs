using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SP_14._09._21.Web.Data;

namespace SP_14._09._21.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Carrera> Carrera { get; set; }
        public DbSet<Gestion> Gestion { get; set; }

        public DbSet<Region> Region { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<SP_14._09._21.Web.Data.Gestion> Gestion_1 { get; set; }
    }
}
