using AppFooD.Models.FormasPagamentos;
using System.Collections.Generic;

namespace AppFooD.Services
{
    public class FormaPagamentoServices
    {
        public List<FormaPagamento> GetFormaPagamentos()
        {
            // arrrumar tudo aqui !
            return new List<FormaPagamento>()
            {
                  new FormaPagamento
                  {
                    FormaPagamentoID = 1,
                    EstabelecimentoID = 1

                 },
                  new FormaPagamento
                {
                    FormaPagamentoID = 2,
                    EstabelecimentoID = 2,
                }
        };
        }
    }
}


//Logo = "https://imagepng.org/wp-content/uploads/2019/05/dinheiro-icone.png",
//Nome = "Dinheiro",