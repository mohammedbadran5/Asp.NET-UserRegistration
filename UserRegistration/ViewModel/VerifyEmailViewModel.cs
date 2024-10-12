using System.ComponentModel.DataAnnotations;

namespace UserRegistration.ViewModel
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage ="Email is required. ")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
