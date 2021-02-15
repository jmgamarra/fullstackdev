using System.ComponentModel.DataAnnotations;

namespace Authentication.Core.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20, MinimumLength = 7,
        ErrorMessage = "Email should be minimum 7 characters and a maximum of 20 characters")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, MinimumLength = 3,
        ErrorMessage = "Password should be minimum 3 characters and a maximum of 20 characters")]
        public string password { get; set; }
    }
}
