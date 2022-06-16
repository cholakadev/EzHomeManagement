namespace EzHomeManagement.Data.Models.EntityModels
{
    public class Apartment
    {
        public Apartment()
        {
            this.UserApartments = new HashSet<UserApartment>();
        }

        public Guid Id { get; set; }
        public string Number { get; set; }
        public int Floor { get; set; }
        public Guid EntranceId { get; set; }
        public Entrance Entrance { get; set; }
        public ICollection<UserApartment> UserApartments { get; set; }
    }
}
