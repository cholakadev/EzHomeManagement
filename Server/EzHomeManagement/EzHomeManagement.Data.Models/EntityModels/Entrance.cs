namespace EzHomeManagement.Data.Models.EntityModels
{
    public class Entrance
    {
        public Entrance()
        {
            this.Apartments = new HashSet<Apartment>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}
