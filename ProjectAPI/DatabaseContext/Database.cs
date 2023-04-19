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

        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Register> Registration { get; set; }
        public virtual DbSet<Sales> Sale { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
