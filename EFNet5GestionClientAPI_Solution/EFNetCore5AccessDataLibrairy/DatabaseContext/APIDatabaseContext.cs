using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFNetCore5AccessDataLibrairy.EntityModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFNetCore5AccessDataLibrairy.DatabaseContext
{
    public class APIDatabaseContext : DbContext //IdentityDbContext

    {
        public APIDatabaseContext(DbContextOptions<APIDatabaseContext> options) : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("dle_adresseBase");
            modelBuilder.Entity<Email>().ToTable("dle_adresseEmailBase");
            modelBuilder.Entity<Client>().ToTable("dle_clientBase");
            modelBuilder.Entity<User>().ToTable("dle_utilisateurBase");

            modelBuilder.Entity<Address>().Property(p => p.CreateDate).HasDefaultValueSql("getutcdate()");
            modelBuilder.Entity<Email>().Property(p => p.CreateDate).HasDefaultValueSql("getutcdate()");
            modelBuilder.Entity<Client>().Property(p => p.CreateDate).HasDefaultValueSql("getutcdate()");
            modelBuilder.Entity<User>().Property(p => p.CreateDate).HasDefaultValueSql("getutcdate()");
            modelBuilder.Entity<User>().Property(p => p.UpdateDate).HasDefaultValueSql("getutcdate()");
        }
    }
}