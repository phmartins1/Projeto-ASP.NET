 using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Payroll.Context;
using Payroll.Models;
using System.Net;
using System.Net.Mail;


namespace Payroll.Controllers
{

    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly AuthService _authService;
        private readonly EmailService _emailService;

        public AccountController(AppDbContext context, AuthService authService, EmailService emailService)
        {
            _context = context;
            _authService = authService;
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Email == email && f.Senha == senha);

            if (funcionario != null)
            {
                HttpContext.Session.SetString("NomeUsuario", funcionario.Nome);
                _authService.SetFuncionarioIdInSession(funcionario.Id);
                return RedirectToAction("Dashboard"); // Redirecionar para a página de dashboard após o login bem-sucedido
            }
            else
            {
                // Autenticação falhou, exiba uma mensagem de erro
                ModelState.AddModelError(string.Empty, "Credenciais inválidas");
                return View();
            }
        }
        public IActionResult Dashboard()
        {
            // Ação da página de dashboard
            return RedirectToAction("Privacy", "Home");
        }
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            return RedirectToAction("Index", "Home");
        }

        public class AuthService
        {
            private readonly IHttpContextAccessor _httpContextAccessor;

            public AuthService(IHttpContextAccessor httpContextAccessor)
            {
                _httpContextAccessor = httpContextAccessor;
            }

            public void SetFuncionarioIdInSession(int Id)
            {
                _httpContextAccessor.HttpContext.Session.SetInt32("FuncionarioId", Id);
            }

            internal int GetFuncionarioIdFromSession()
            {
                return _httpContextAccessor.HttpContext.Session.GetInt32("FuncionarioId") ?? 0;
            }

        }

        [HttpPost]
        public IActionResult EnviarEmail(string email)
        {
            try
            {
                var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Email == email);

                if (funcionario != null)
                {
                    string corpoEmail = $"<p>O Sistema Nakamura Payroll Administrator relembra que sua senha é: {funcionario.Senha}</p>";

                    _emailService.EnviarEmail(email, "Nakamura Payroll Administrator", corpoEmail);

                    // Redirecionar para uma página de sucesso, erro, etc.
                    return RedirectToAction("Login", "Account"); // Redirecionar para uma página de sucesso
                }
                else
                {
                    // Usuário não encontrado, redirecione ou lide conforme necessário
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                // Lidar com exceções
                return RedirectToAction("Index", "Home"); // Redirecionar para uma página de erro
            }
        }


    }
}