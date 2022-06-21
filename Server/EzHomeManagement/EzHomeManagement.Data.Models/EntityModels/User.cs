namespace EzHomeManagement.Data.Models.EntityModels
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.UserApartments = new HashSet<UserApartment>();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsOwner { get; set; }
        public bool IsLessee { get; set; }
        public DateTime? AccommodationDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public bool? IsCurrentResident { get; set; }
        public ICollection<UserApartment> UserApartments { get; set; }
    }
}
