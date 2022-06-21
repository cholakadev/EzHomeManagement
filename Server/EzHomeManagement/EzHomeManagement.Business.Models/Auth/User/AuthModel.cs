namespace EzHomeManagement.Business.Models.Auth.User
{
    using System.ComponentModel.DataAnnotations;

    public class AuthModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
