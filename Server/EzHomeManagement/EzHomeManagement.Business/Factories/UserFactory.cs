namespace EzHomeManagement.Business.Factories
{
    using EzHomeManagement.Business.Models.Auth.User;
    using EzHomeManagement.Data.Models.EntityModels;

    public static class UserFactory
    {
        public static UserModel ToModel(this User user)
            => new UserModel
            {
                Id = user.Id,
                Email = user.Email
            };
    }
}
