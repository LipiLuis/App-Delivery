using System;
using AppFooD.Helps.Enum;
using AppFooD.Models;
using System.Collections.Generic;

namespace AppFooD.Services
{
    public class EstabelecimentoServices
    {
        public List<Estabelecimento> GetEstabelecimentos()
        {
            var estabelecimentos = new List<Estabelecimento>()
            {
                  new Estabelecimento(){
                    Logo = "https://imagesapt.apontador-assets.com/fit-in/320x240/7bfbd4406aea48deaf1c4de33886275d/paulista-pizzaria.png",
                    Nome = "Pizzaria Paulista",
                    EstabelecimentoID = 1,
                    Star = 5,
                    DataEntrega = DateTime.Now.AddMinutes(5),
                    endereco = new Endereco
                    {
                        Bairro = "Ginásio",
                        Cep = "48700000",
                        Rua = "André Negreiro Falcão",
                        Municipio = "Serrinha",
                        Numero = 39,
                        UF = "BA",

                    },
                    AbertoFechado = "Aberto",
                    IconLocation = "LocationGren.png",
                    PrecoDelivery = 3.00M,
                },
                  new Estabelecimento(){
                    Logo = "https://static-images.ifood.com.br/image/upload/t_high/logosgde/201909201215_07fad584-41be-471c-8366-d35455934338.png",
                    Nome = "Bj Pizzas",
                    Star = 4.5M,
                    DataEntrega = (DateTime.Now.AddMinutes(40)),
                    EstabelecimentoID = 2,
                    AbertoFechado = "Aberto",
                    IconLocation = "LocationGren.png",
                    endereco = new Endereco
                    {
                        Bairro = "Centro",
                        Cep = "48700000",
                        Rua = "Valdete Carneiro",
                        Municipio = "Serrinha",
                        Numero = 397,
                        UF = "BA",
  
                    },
                    PrecoDelivery = 4.00M,
                },
                  new Estabelecimento(){
                    Logo = "ParaisoDasMassas.jfif",
                    Nome = "Paraíso Das Massas",
                    DataEntrega = (DateTime.Now.AddMinutes(50)),
                    Star = 0,
                    endereco = new Endereco
                    {
                        Bairro = "Ginásio",
                        Cep = "48700000",
                        Rua = "Praça Morena Bella",
                        Municipio = "Serrinha",
                        Numero = 377,
                        UF = "BA",

                    },
                    EstabelecimentoID = 3,
                    AbertoFechado = "Fechado",
                    IconLocation = "LocationRed.png",
                    PrecoDelivery = 5.00M,
                },
                  new Estabelecimento(){
                    Logo = "losmota.jfif",
                    Nome = "Los Mota",
                    DataEntrega = (DateTime.Now.AddMinutes(50)),
                    Star = 0,
                    endereco = new Endereco
                    {
                        Bairro = "Centro",
                        Cep = "48700000",
                        Rua = "Av. Luís Viana Filho",
                        Municipio = "Serrinha",
                        Numero = 886,
                        UF = "BA",

                    },
                    EstabelecimentoID = 4,
                    AbertoFechado = "Aberto",
                    IconLocation = "LocationGren.png",
                    PrecoDelivery = 4.00M,
                },
            };
            return estabelecimentos;
        }
    }
}
