using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BurgerMarket.Domain.Entities;

namespace BurgerMarket.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(b => b.Id);
            
            builder.Property(e => e.AddressId)
                .HasColumnName("AddressID")
                .IsRequired();

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired();
            
        }
    }
}
