using System.ComponentModel.DataAnnotations;

namespace Crito.Models
{
    public class SignupForm
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; } = null!;
    }
}
