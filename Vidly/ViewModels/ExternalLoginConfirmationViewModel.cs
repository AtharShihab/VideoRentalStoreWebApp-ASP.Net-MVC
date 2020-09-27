using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [StringLength(90)]
        [Required]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
