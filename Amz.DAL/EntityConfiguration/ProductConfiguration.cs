using Amz.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amz.DAL.EntityConfiguration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(255);
            builder.Property(p => p.Description).HasMaxLength(150);

            //builder.HasOne<Category>(c => c.Category)
            //    .WithMany(p => p.Products)
            //    .HasForeignKey(s => s.CategoryId);
        }
    }
}
