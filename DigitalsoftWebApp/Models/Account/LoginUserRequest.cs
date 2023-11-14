using System.ComponentModel.DataAnnotations;

namespace DigitalsoftWebApp.Models.Account
{
    public class LoginUserRequest
    {
        [Required]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
