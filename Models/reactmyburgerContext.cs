using System;
using BurgerApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BurgerApp.Models
{
    public partial class reactmyburgerContext : DbContext
    {
        public reactmyburgerContext()
        {
        }

        public reactmyburgerContext(DbContextOptions<reactmyburgerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //warning To protect potentially sensitive information in your connection string, you should move it out of source code
        //        optionsBuilder.UseSqlServer("Data Source=SHUBHASR-IN;Database=react-my-burger;Integrated Security=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new IngredientsConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());

            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.Property(e => e.CustomerId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("customerID");

            //    entity.Property(e => e.Country)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("country");

            //    entity.Property(e => e.Delivery)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("delivery");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("email");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("name");

            //    entity.Property(e => e.Street)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("street");

            //    entity.Property(e => e.ZipCode)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("zipCode");
            //});

            //modelBuilder.Entity<Ingredient>(entity =>
            //{
            //    entity.Property(e => e.Id)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("id")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Bacon)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("bacon");

            //    entity.Property(e => e.Cheese)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("cheese");

            //    entity.Property(e => e.Meat)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("meat");

            //    entity.Property(e => e.Salad)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("salad");
            //});

            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.Property(e => e.OrderId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("orderID");

            //    entity.Property(e => e.Bacon)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("bacon");

            //    entity.Property(e => e.Cheese)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("cheese");

            //    entity.Property(e => e.Meat)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("meat");

            //    entity.Property(e => e.Salad)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("salad");

            //    entity.Property(e => e.TotalPrice)
            //        .HasColumnType("numeric(18, 0)")
            //        .HasColumnName("totalPrice");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
