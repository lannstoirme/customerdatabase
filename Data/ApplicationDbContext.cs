using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MicahCustomerManager.Models;

namespace MicahCustomerManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MicahCustomerManager.Models.Customer> Customer { get; set; }
        public DbSet<MicahCustomerManager.Models.Procedure> Procedure { get; set; }
    }
}
