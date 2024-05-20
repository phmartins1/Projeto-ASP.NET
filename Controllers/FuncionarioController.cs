using Microsoft.AspNetCore.Mvc;
using Payroll.Context;
using Payroll.Repositories.Interfaces;
using System.Security.Claims;

namespace Payroll.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionarioController(AppDbContext context)
        {
            _context = context;
        }

       /* public IActionResult Inser
        {
            get
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obtém o ID do usuário atualmente logado
                var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Id == userId);

                if (funcionario != null)
                {
                    // Coloque as informações do funcionário na sessão
                    HttpContext.Session.SetString("FuncionarioId", funcionario.FuncionarioId.ToString());
                    HttpContext.Session.SetString("FuncionarioNome", funcionario.Nome);
                }

            }
        }*/
    }
}
