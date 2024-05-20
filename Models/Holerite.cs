using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Payroll.Models
{
    [Table("Holerites")]
    public class Holerite
    {
        [Key]
        public int HoleriteId { get; set; }
        [Required(ErrorMessage = "O título do holerite deve ser obrigatório")]
        [Display(Name = "Título do Holerite")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string HoleriteName { get; set; }
        [Display(Name = "Data do Holerite")]
        [StringLength(10, ErrorMessage = "O tamanho máximo é 10 caracteres")]
        public string DataHolerite { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string ImagemUrl { get; set; }

        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }

        public virtual Funcionario Funcionario { get; set; }
    }
}
