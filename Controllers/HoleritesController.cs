using Microsoft.AspNetCore.Mvc;
using Payroll.Repositories.Interfaces;
using Payroll.Models;
using Payroll.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Payroll.Controllers
{
    public class HoleritesController : Controller
    {
        private readonly IHoleritesRepository _holeriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor; // Adicione o contexto HTTP para acessar a sessão.
      

        public HoleritesController(IHoleritesRepository holeriteRepository, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _holeriteRepository = holeriteRepository;
            _httpContextAccessor = httpContextAccessor;
            
        }


        [HttpGet]
        public IActionResult List()
        {
            int funcionarioId = GetFuncionarioIdFromSession(); // Obtenha o ID do funcionário logado da sessão.

            var holeriteListViewModel = new HoleriteListViewModel();
            holeriteListViewModel.Id = funcionarioId.ToString();
            holeriteListViewModel.Holerites = GetHoleritesDoFuncionario(funcionarioId);
            holeriteListViewModel.FuncionarioAtual = "Funcionario Logado";

            return View(holeriteListViewModel);
        }

        private int GetFuncionarioIdFromSession()
        {
            // Obtenha o ID do funcionário da sessão, substitua "FuncionarioId" pelo nome da chave usada na sessão.
            int? funcionarioId = _httpContextAccessor.HttpContext.Session.GetInt32("FuncionarioId");
            if (funcionarioId.HasValue)
            {
                return funcionarioId.Value;
            }
            else
            {
                // Lide com o caso em que o ID do funcionário não está na sessão (por exemplo, redirecione para a página de login).
                return 0; // Ou outro valor adequado.
            }
        }

        private List<Holerite> GetHoleritesDoFuncionario(int funcionarioId)
        {
            // Consulte os Holerites do funcionário com base no ID do funcionário.
            var holeritesDoFuncionario = _holeriteRepository.Holerite
                .Where(h => h.FuncionarioId == funcionarioId)
                .ToList();

            return holeritesDoFuncionario;
        }

        [HttpGet]
        public IActionResult DownloadPDF(string pdfFileName)
        {
            // Verifique se o nome do arquivo não está vazio ou nulo
            if (!string.IsNullOrEmpty(pdfFileName))
            {
                // Construa o caminho completo para o arquivo PDF
                var pdfPath = Path.Combine("wwwroot/PDFs", pdfFileName);

                if (System.IO.File.Exists(pdfPath))
                {
                    // Determine o tipo MIME do arquivo (nesse caso, PDF)
                    var contentType = "application/pdf";

                    // Retorne o arquivo para download
                    return File(System.IO.File.ReadAllBytes(pdfPath), contentType, pdfFileName);
                }
            }

            // Trate o caso em que o arquivo não foi encontrado ou é inválido
            return RedirectToAction("Erro");
        }


    }
}