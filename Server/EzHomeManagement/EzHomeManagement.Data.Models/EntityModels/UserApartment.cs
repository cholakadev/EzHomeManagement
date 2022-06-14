namespace EzHomeManagement.Data.Models.EntityModels
{
    public class UserApartment
    {
        public Guid UserId { get; set; }
        public Guid ApartmentId { get; set; }
        public User User { get; set; }
        public Apartment Apartment { get; set; }
    }
}
