namespace EzHomeManagement.Data.Configuration
{
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserApartmentEntityConfiguration : IEntityTypeConfiguration<UserApartment>
    {
        public void Configure(EntityTypeBuilder<UserApartment> builder)
        {
            builder
                .ToTable("UserApartment")
                .HasKey(ua => new { ua.UserId, ua.ApartmentId });
        }
    }
}
