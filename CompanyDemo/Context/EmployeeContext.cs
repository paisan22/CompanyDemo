using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CompanyDemo.Models;

namespace CompanyDemo.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}
