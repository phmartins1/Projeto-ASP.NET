using Microsoft.AspNetCore.Http;

namespace Payroll.ViewModels
{ 
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
        public int GetFuncionarioIdFromSession()
        {
            return _httpContextAccessor.HttpContext.Session.GetInt32("FuncionarioId") ?? 0;
        }
    }
}
