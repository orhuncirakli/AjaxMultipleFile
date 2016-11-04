using AjaxMultipleFile.Models;

namespace AjaxMultipleFile.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AjaxEntity : DbContext
    {
        public AjaxEntity()
            : base("name=AjaxEntity")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
