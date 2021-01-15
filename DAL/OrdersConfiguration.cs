using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.DAL
{
    public class OrdersConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            
            builder.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orderID")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Bacon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bacon");

            builder.Property(e => e.Cheese)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cheese");

            builder.Property(e => e.Meat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("meat");

            builder.Property(e => e.Salad)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salad");

            builder.Property(e => e.TotalPrice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("totalPrice");
        }
    }
}
