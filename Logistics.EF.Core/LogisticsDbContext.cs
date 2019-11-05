using Logistics.EF.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logistics.EF.Core
{
   
    public class LogisticsDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Evaluate> Evaluates { get; set; }
        public virtual DbSet<DataDic> DataDics { get; set; }
        
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Distribution> Distributions { get; set; }

        public LogisticsDbContext(DbContextOptions<LogisticsDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Evaluate>().ToTable("Evaluate");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
            modelBuilder.Entity<DataDic>().ToTable("DataDic");
            modelBuilder.Entity<Distribution>().ToTable("Distribution");

        }

    }
}
