namespace EzHomeManagement.Business.Models.Auth.Entrance
{
    public class RegisterEntranceModel
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Auto generated unique entrance code. 
        /// It is usable when a user wants to register to connect to the same entrance.
        /// </summary>
        public string Code { get; set; }
        public string Number { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
