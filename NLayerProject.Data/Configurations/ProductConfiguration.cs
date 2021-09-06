using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.Id).UseIdentityColumn(); // yeni ürün eklendikçe ıd yi 1er arttır
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200); //zorunlu ve max 200 karakter
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");  //18.23 vb
            builder.Property(x => x.InnerBarcode).HasMaxLength(50);
            builder.ToTable("Products");

        }
    }
}
