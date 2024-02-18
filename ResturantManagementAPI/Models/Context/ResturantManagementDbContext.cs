﻿using Microsoft.EntityFrameworkCore;
using ResturantManagementAPI.Models.Entites;
using ResturantManagementAPI.Models.EntityConfiguration;

namespace ResturantManagementAPI.Models.Context
{
    public class ResturantManagementDbContext : DbContext
    {
        public ResturantManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //method - 1
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x=>x.Id).UseIdentityColumn();
            //method -2
            modelBuilder.ApplyConfiguration(new CartEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CartItemEntityTypeConfiguration());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Ingredidiante> Ingredidiantes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemIngredidiante> ItemIngredidiantes { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealItem> MealItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
