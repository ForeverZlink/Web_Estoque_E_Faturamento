#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Web_Estoque_E_Faturamento._Models;

    public class MvcProductContext : DbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasOne(p=>p.ProductInventory)
            .WithOne(p=>p.Product).HasForeignKey<ProductInventory>(e=>e.ProductId);

            modelBuilder.Entity<ProductInventoryRegisterPurchase>().HasOne(p=>p.ProductInventory)
            .WithMany(p=>p.ProductInventoryRegisterPurchase).OnDelete(DeleteBehavior.NoAction);
            
           

        }

        public DbSet<Web_Estoque_E_Faturamento._Models.Product> Product { get; set; }
        public DbSet<Web_Estoque_E_Faturamento._Models.ProductInventory> ProductInventory {get;set;}
        public DbSet<Web_Estoque_E_Faturamento._Models.ProductInventoryRegisterPurchase> ProductInventoryRegisterPurchase {get;set;}
        public DbSet<Web_Estoque_E_Faturamento._Models.Provider> Provider {get;set;}
        
    }
