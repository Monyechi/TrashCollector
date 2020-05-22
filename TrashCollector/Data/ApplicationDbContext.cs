using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "b33dd34c-e638-41ac-ad7d-7b68ab478923",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            },

            new IdentityRole
            {
                Id = "19e310c8-d429-4950-97a2-26c668d95e99",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            }
            );
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Employee> Employee { get; set; }
    }
}

