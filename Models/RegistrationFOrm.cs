using System.ComponentModel.DataAnnotations;

namespace MVCIIFOrmsubmission.Models {
    public class RegistrationFOrm {
        [Required (ErrorMessage = "First Name must be at least 4 Characters Long")]
        [Display (Name = "First Name :")]
        [MinLength (4)]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last Name must be at least 4 Characters Long")]
        [Display (Name = "Last Name :")]
        [MinLength (4)]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Age must be a Positive Number")]
        [Display (Name = "Age :")]
        [Range (0, 125)]
        public int? Age { get; set; }

        [Required (ErrorMessage = "Email must be in Valid Format")]
        [Display (Name = "Email :")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage="Password Must be atleast 8 Characters")]
        [Display(Name="Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage="Confirm Password Must Match Password")]
        [Display(Name="Confirm Password :")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}