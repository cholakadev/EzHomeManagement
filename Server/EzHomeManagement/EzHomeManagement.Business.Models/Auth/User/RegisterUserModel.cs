namespace EzHomeManagement.Business.Models.Auth.User
{
    public class RegisterUserModel : AuthModel
    {
        public string PasswordSalt { get; private set; } = Guid.NewGuid().ToString("N");
    }
}
