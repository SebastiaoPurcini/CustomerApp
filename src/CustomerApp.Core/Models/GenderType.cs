using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Core.Models
{
    public enum GenderType
    {
        [Display(Name = "Feminino")]
        Feminine = 1,
        [Display(Name = "Masculino")]
        Masculine = 2,
        [Display(Name = "Não informado")]
        Undefined = 3
    }
}
