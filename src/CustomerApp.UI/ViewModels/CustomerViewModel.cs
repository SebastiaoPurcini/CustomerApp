using CustomerApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace CustomerApp.UI.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage ="O valor máximo para o campo {0} é {1}")]
        public string Name { get; set; }

        [Display(Name = "Idade")]
        [Range(1, 150, ErrorMessage = "O campo {0} deve ter entre {1} e {2}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Age { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public GenderType Gender { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O valor máximo para o campo {0} é {1}")]
        public string State { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O valor máximo para o campo {0} é {1}")]
        public string City { get; set; }
    }
}