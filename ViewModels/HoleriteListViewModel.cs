using Payroll.Models;

namespace Payroll.ViewModels
{
    public class HoleriteListViewModel
    {
        public IEnumerable<Holerite> Holerites { get; set; }
        public string FuncionarioAtual { get; set; }
        public string Id { get; set; }
        public string ImagemURL { get; set; }
        public int HoleriteId { get; set; }
        public string DataHolerite { get; set; }
    }
}
