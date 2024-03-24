using Medicine.Entities.Models.Auth;

namespace Medicine.Web.UseCases.Models.GraphqlResponse.Users
{
    public class UserResponse : User
    {
        public string? TimeInUtc { get; set; } = "00:00";

    }
}
