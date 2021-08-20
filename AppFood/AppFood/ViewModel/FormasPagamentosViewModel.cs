using AppFooD.Helps.Enum;
using AppFooD.Models;
using AppFooD.Models.FormasPagamentos;
using AppFooD.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class FormasPagamentosViewModel : BaseViewModel
    {
        TipoFormaPagamenoEnum[] formaPagamenoEnum { get; set; } //= new List<TipoFormaPagamenoEnum>();

        private List<FormPagamentoGroup> _FormaPagamentoGroup;
        public List<FormPagamentoGroup> FormaPagamentoGroup
        {
            get { return _FormaPagamentoGroup; }
            set { SetProperty(ref _FormaPagamentoGroup, value); }
        }
        public ICommand FormaPagamentoSelecionadoCommand { get; set; }
        public FormasPagamentosViewModel()
        {
            formaPagamenoEnum = (TipoFormaPagamenoEnum[])Enum.GetValues(typeof(TipoFormaPagamenoEnum));
        }



        public List<FormPagamentoGroup> ListarFormasEntrega()
        {
            return new FormPagamentoGroupServices()
                 .ListFormaPagamentoGroup()
                 .Where(f => formaPagamenoEnum.Contains(f.tipoFormaPagameno) && f.tipoFormaPagameno != TipoFormaPagamenoEnum.CarteiraDigital).ToList();

        }
        public List<FormPagamentoGroup> ListarFormasApp()
        {
            return new FormPagamentoGroupServices()
                     .ListFormaPagamentoGroup()
                     .Where(f => formaPagamenoEnum.Contains(f.tipoFormaPagameno) && f.tipoFormaPagameno == TipoFormaPagamenoEnum.CarteiraDigital).ToList();

        }
        public void ListarFormaPagamento(Estabelecimento estabelecimento, List<FormPagamentoGroup> FormaPagamento)
        {
            List<Cartao> Cartoes = new List<Cartao>();
            FormaPagamentoGroup = new List<FormPagamentoGroup>();
            if (FormaPagamento != null)
            {
                for (int i = 0; i < FormaPagamento.Count; i++)
                {
                    Cartoes = FormaPagamento[i].Where(d => d.EstabelecimentoID == estabelecimento.EstabelecimentoID).Select(a => a).ToList();
                    if (Cartoes != null && Cartoes.Count > 0)
                    {
                        var formaPagamentogroup = estabelecimento.FormPagamento = new FormPagamentoGroup(FormaPagamento[i].tipoFormaPagameno, Cartoes);
                        FormaPagamentoGroup.Add(formaPagamentogroup);
                    }
                }

            }

        }
    }

}
