using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength( 16, MinimumLength = 4, ErrorMessage = "Must specifiy password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}