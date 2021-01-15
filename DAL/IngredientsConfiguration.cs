using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.DAL
{
    public class IngredientsConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {

            builder.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id")
                .HasDefaultValueSql("((1))");

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
        }
    }
}
