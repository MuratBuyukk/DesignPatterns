using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
