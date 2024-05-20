using Payroll.Context;
using Payroll.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Payroll.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do funcionário deve ser obrigatório")]
        [Display(Name = "Nome do Funcionário")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "E-mail invalido, por favor digite um e-mail válido")]
        [Display(Name = "E-mail do funcionário")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string Email { get; set; }
        [StringLength(20, ErrorMessage = "O tamanho máximo é 20 caracteres")]
        [Required]
        public string Senha { get; set; }
        public List<Holerite> Holerite { get; set; }
        
    }
}
