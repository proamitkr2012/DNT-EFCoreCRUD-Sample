using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCodeFirstLib
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=LAPTOP-8VH34DE5; initial catalog=EmployeeDB_ADO;persist security info=True;user id=sa;password=developer;");
            }
        }
    }
}
