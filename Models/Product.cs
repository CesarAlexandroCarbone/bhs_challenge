using Microsoft.EntityFrameworkCore;

namespace BhsChallenge.Models
{
    public class Product : Base
    {
        public string? Name { get; set; }
        public Boolean Status { get; set; }
    }

    namespace Mapping
    {
        public static class ProductMapping
        {
            public static ModelBuilder OnProductCreating(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>(entity =>
                {
                    entity.ToTable("Products");
                    entity.Property(e => e.Id).HasColumnName("id_product").IsRequired();
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                    entity.Property(e => e.Status).HasColumnName("status").IsRequired();
                });
                return modelBuilder;
            }
        }
    }
}
