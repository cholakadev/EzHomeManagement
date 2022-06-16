namespace EzHomeManagement.Data.Configuration
{
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApartmentEntityConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder
                .ToTable("Apartment")
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(a => a.Floor)
                .IsRequired();
        }
    }
}
