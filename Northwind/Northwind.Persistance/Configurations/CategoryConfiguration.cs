using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Persistance.Entities;

namespace Northwind.Persistance.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id); //fluent mapping

        builder.Property(x => x.Id).HasColumnName("CategoryID");
        builder.Property(x => x.Name).HasColumnName("CategoryName");
    }
}
