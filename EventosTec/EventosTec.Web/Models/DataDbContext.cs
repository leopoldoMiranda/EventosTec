using EventosTec.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models
{
    public class DataDbContext:DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options):base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}

