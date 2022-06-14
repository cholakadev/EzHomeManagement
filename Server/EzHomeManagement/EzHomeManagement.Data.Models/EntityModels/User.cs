namespace EzHomeManagement.Data.Models.EntityModels
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOwner { get; set; }
        public bool IsLessee { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool IsCurrentResident { get; set; }
    }
}
