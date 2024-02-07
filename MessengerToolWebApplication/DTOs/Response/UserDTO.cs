using MessengerToolWebApplication.Models;

namespace MessengerToolWebApplication.DTOs.Responses
{
    /// <summary>
    /// DTO for user
    /// </summary>
    public class UserDTO : User
    {
        public new string? Id { get; set; }
    }
}
