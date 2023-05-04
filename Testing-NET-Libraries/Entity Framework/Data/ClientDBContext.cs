using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_NET_Libraries.Entity_Framework.Models;

namespace Testing_NET_Libraries.Entity_Framework.Data
{
    internal class ClientDBContext : DbContext
    {
        public ClientDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=clients_db;Trusted_Connection=True;TrustServerCertificate=True;");
        } 

        public DbSet<Client> Clients { get; set; }


    }
}
