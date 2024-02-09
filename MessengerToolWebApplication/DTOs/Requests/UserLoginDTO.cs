using System.ComponentModel.DataAnnotations;

namespace MessengerToolWebApplication.DTOs.Requests
{
    /// <summary>
    /// DTO for user login
    /// </summary>
    public class UserLoginDTO
    {
        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Password { get; set; }
    }
}
