using Payroll.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [Column("FuncionarioId")]
        public int FuncionarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        
    }
}