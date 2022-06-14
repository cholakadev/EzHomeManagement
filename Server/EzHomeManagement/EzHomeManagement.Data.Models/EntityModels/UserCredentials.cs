namespace EzHomeManagement.Data.Models.EntityModels
{
    public class UserCredentials
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
    }
}
