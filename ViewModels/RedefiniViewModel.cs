using System.ComponentModel.DataAnnotations;

namespace Payroll.ViewModels
{
    public class RedefiniViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string ReturnUrl { get; set; }
    }
}
