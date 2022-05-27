using CustomerApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerApp.Infra.Mappers
{
    public class CustomerMapper : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
            .IsRequired()
            .HasColumnType("VARCHAR(40)");

            builder.Property(c => c.Age)
                .IsRequired();

            builder.Property(c => c.Gender)
                .IsRequired();

            builder.Property(c => c.State)
                .IsRequired()
                .HasColumnType("VARCHAR(2)");

            builder.Property(c => c.City)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.ToTable("Customers");
        }
    }
}
