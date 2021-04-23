using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан номер телефона")]
        [RegularExpression(@"^(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?$", ErrorMessage = "Введенный формат телефона недействителен")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
