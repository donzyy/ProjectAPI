using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Model;

namespace ProjectAPI.DatabaseContext
{
    public class Database: DbContext
    {
        public Database(DbContextOptions<Database>options): base(options)
        {

        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registration { get; set; }
        public DbSet<Sales> Sale { get; set; }
    }
}
