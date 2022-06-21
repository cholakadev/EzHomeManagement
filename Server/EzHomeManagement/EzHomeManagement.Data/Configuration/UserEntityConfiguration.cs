namespace EzHomeManagement.Data.Configuration
{
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("User")
                .HasKey(u => u.Id);

            builder
                .Ignore(u => u.UserName)
                .Ignore(u => u.NormalizedUserName)
                .Ignore(u => u.SecurityStamp)
                .Ignore(u => u.PhoneNumberConfirmed)
                .Ignore(u => u.TwoFactorEnabled)
                .Ignore(u => u.LockoutEnd)
                .Ignore(u => u.LockoutEnabled);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(128);

            builder
                .Property(u => u.FirstName)
                .HasMaxLength(64);

            builder
               .Property(u => u.LastName)
               .HasMaxLength(64);

            builder
               .Property(u => u.PhoneNumber)
               .HasMaxLength(32);

            builder
                .Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(512);

            builder
                .Property(u => u.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);

            builder
                .Property(u => u.IsLessee)
                .HasDefaultValue(false);

            builder
                .Property(u => u.IsOwner)
                .HasDefaultValue(false);

            builder
                .Property(u => u.IsCurrentResident)
                .HasDefaultValue(true);
        }
    }
}
