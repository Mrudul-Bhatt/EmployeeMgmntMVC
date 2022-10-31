using System;
using EmpMgmnt_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpMgmnt_MVC.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}

