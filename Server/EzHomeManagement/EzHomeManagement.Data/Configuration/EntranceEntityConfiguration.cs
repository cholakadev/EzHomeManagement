namespace EzHomeManagement.Data.Configuration
{
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EntranceEntityConfiguration : IEntityTypeConfiguration<Entrance>
    {
        public void Configure(EntityTypeBuilder<Entrance> builder)
        {
            builder
                .ToTable("Entrance")
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(16);

            builder
               .Property(e => e.Town)
               .IsRequired()
               .HasMaxLength(64);

            builder
               .Property(e => e.Country)
               .IsRequired()
               .HasMaxLength(64);

            builder
                .Property(u => u.Address)
                .IsRequired()
                .HasMaxLength(128);
        }
    }
}
