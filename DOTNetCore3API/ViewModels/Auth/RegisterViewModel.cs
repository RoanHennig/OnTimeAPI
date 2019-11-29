using System.ComponentModel.DataAnnotations;

namespace DOTNetCore3API.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [StringLength(80)]
        public string BusinessName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public string Auth0UserId { get; set; }
    }
}
