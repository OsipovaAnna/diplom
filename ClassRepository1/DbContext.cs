using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Context
{
    public class WebDbContext : DbContext
    {
        public WebDbContext() : base("DBase")
        {
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Task> Tasks { get; set; }
    }
}
