using AppFooD.Models;
using AppFooD.Models.FormasPagamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFooD.Services
{
    public class FormPagamentoGroupServices
    {
        public List<FormPagamentoGroup> ListFormaPagamentoGroup()
        {
            return new List<FormPagamentoGroup>
            {
                new FormPagamentoGroup(Helps.Enum.TipoFormaPagamenoEnum.Dinheiro, new  List<Cartao>{

                new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 1,
                     Logo = "wallet",
                     Nome = "Dinheiro",
                },
                new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 2,
                     Logo = "wallet",
                     Nome = "Dinheiro",
                },
                 new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 3,
                     Logo = "wallet",
                     Nome = "Dinheiro",
                },
                  new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 4,
                     Logo = "wallet",
                     Nome = "Dinheiro",
                },
                   new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 5,
                     Logo = "wallet",
                     Nome = "Dinheiro",
                }
                }),
                new FormPagamentoGroup(Helps.Enum.TipoFormaPagamenoEnum.CartaoCredito, new List<Cartao>{

                new Cartao
                {
                     CartaoID = 1,
                     EstabelecimentoID = 1,
                     Logo = "Visa",
                     Nome = "Visa",
                },
                new Cartao
                {
                     CartaoID = 2,
                     EstabelecimentoID = 1,
                     Logo = "Mastercard",
                     Nome = "Master",
                },
                new Cartao
                {
                    CartaoID = 3,
                    EstabelecimentoID =1,
                    Logo = "hipercard",
                    Nome = "Hiper",
                },
                new Cartao
                {
                    CartaoID = 4,
                    EstabelecimentoID = 1,
                    Logo = "elo",
                    Nome = "Elo",
                },
                 new Cartao
                {
                    CartaoID = 11,
                    EstabelecimentoID = 2,
                    Logo = "Visa",
                    Nome = "Visa",
                },
                new Cartao
                {
                    CartaoID = 12,
                    EstabelecimentoID = 2,
                    Logo = "Mastercard",
                    Nome = "Master",
                },
                new Cartao
                {
                    CartaoID = 13,
                    EstabelecimentoID = 2,
                    Logo = "hipercard",
                    Nome = "Hiper",
                },
                new Cartao
                {
                    CartaoID = 12,
                    EstabelecimentoID = 2,
                    Logo = "elo",
                    Nome = "Elo",
                },
                new Cartao
                {
                    CartaoID = 14,
                    EstabelecimentoID = 2,
                    Logo = "https://image.flaticon.com/icons/png/512/179/179431.png",
                    Nome = "American Express",
                },
                }),
                new FormPagamentoGroup(Helps.Enum.TipoFormaPagamenoEnum.CartaoDebito, new List<Cartao>
                {
                 new Cartao
                {
                    CartaoID = 5,
                    EstabelecimentoID = 1,
                    Logo = "Visa",
                    Nome = "Visa",
                },
                new Cartao
                {
                    CartaoID = 6,
                    EstabelecimentoID = 1,
                    Logo = "Mastercard",
                    Nome = "Master",
                },
                new Cartao
                {
                    CartaoID = 7,
                    EstabelecimentoID = 1,
                    Logo = "elo",
                    Nome = "Elo",
                },
                new Cartao
                {
                    CartaoID = 15,
                    EstabelecimentoID = 2,
                    Logo = "Visa",
                    Nome = "Visa",
                },
                new Cartao
                {
                    CartaoID = 16,
                    EstabelecimentoID = 2,
                    Logo = "elo",
                    Nome = "Elo",
                },
                }),
                new FormPagamentoGroup(Helps.Enum.TipoFormaPagamenoEnum.CarteiraDigital, new List<Cartao>{
                new Cartao
                {
                    CartaoID = 8,
                    EstabelecimentoID = 1,
                    Logo = "https://fdr.com.br/wp-content/uploads/2020/05/picpay-logo-1-e1577071801612.png",
                    Nome = "PicPay",
                },
                new Cartao
                {
                    CartaoID = 9,
                    EstabelecimentoID = 1,
                    Logo = "https://img.olhardigital.com.br/wp-content/uploads/2021/03/images.png",
                    Nome = "Mercado pago",
                },
                new Cartao
                {
                    CartaoID = 10,
                    EstabelecimentoID = 1,
                    Logo = "https://docmanagement.com.br/wp-content/uploads/2020/09/1-40.jpg",
                    Nome = "PIX",
                },
                })
            };
        }

        //public List<FormPagamentoGroup> GeFormaPagamentoGroup(Estabelecimento estabelecimento)
        //{
        //    var CartaoServices = new CartoesServices().GetPagamentoEntregas().ToList();
        //    var query = ListFormaPagamentoGroup().FirstOrDefault(p => p.Where(a => a.EstabelecimentoID == estabelecimento.EstabelecimentoID));
        //    var formaPagamento = ListFormaPagamentoGroup().Select(f => f.FirstOrDefault(x => x.EstabelecimentoID == estabelecimento.EstabelecimentoID)).ToList();
        //}

    }
}
