
using TechnicalAssessment.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TechnicalAssessment.Users
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }

        public DbSet<Crypto_Transactions> Crypto_Transactions { get; set; }
        public DbSet<Log_Request> Log_Requests { get; set; }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
