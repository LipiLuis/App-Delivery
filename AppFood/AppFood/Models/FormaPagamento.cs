using AppFooD.Models.FormasPagamentos;

namespace AppFooD.Models
{
    public abstract class FormaPagamento : Dinheiro
    {
        public string Logo { get; set; }
        public string Nome { get; set; }
    }
}