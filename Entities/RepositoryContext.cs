using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Uncle",
                LastName = "Bob",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"
            }, new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Kirsten",
                Email = "jan.kirsten@gmail.com",
                DateOfBirth = new DateTime(1981, 07, 13),
                PhoneNumber = "111-222-3333"
            });

            modelBuilder.Entity<Owner>().HasData(new Owner
            {
                IdOwner = Guid.NewGuid(),
                Name = "John Keen",
                DateOfBirth = new DateTime(1980, 12, 05),
                Address = "61 Wellfield Road"
            }, new Owner
            {
                IdOwner = Guid.NewGuid(),
                Name = "Anna Bosh",
                DateOfBirth = new DateTime(1974, 11, 14),
                Address = "27 Colored Row"
            }, new Owner
            {
                IdOwner = Guid.NewGuid(),
                Name = "Sam Query",
                DateOfBirth = new DateTime(1990, 04, 22),
                Address = "91 Western Roads"
            }, new Owner
            {
                IdOwner = Guid.NewGuid(),
                Name = "Martin Miller",
                DateOfBirth = new DateTime(1983, 05, 21),
                Address = "3 Edgar Buildings"
            });
        }
    }
}