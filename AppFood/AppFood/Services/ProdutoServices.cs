using AppFooD.Models;
using System.Collections.Generic;

namespace AppFooD.Services
{
    public class ProdutoServices
    {
        public List<Produto> GetProdutos()
        {
            var ListProdutos = new List<Produto>
                           {
                        new Produto
                        {
                            Nome = " PIZZA CALABRESA",
                            Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                            Preco = 24m,
                            ProdutoID = 1,
                            CategoriaProdutoId = 1,
                            Promocao = true,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            Logo = "https://pilotandofogao.com.br/wp-content/uploads/2016/05/Pizza-De-Calabresa.jpg",

                        },
                        new Produto
                        {
                            Nome = " PIZZA Mista",
                            Descricao = "Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.",
                            Preco = 22m,
                            ProdutoID = 2,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            Promocao = true,
                            Logo = "http://www.redelevepizza.com.br/assets/imagens/pizzas/034/mista.jpg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA BACON",
                            Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                            Preco = 20.0m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            Promocao = true,
                            ProdutoID = 3,
                            Logo = "https://i.pinimg.com/originals/44/f6/ce/44f6ce2704518205275ac93955a85c80.jpg",
                        },
                        new Produto
                        {
                            Nome = " PIZZA BAIANA",
                            Descricao = "Molho picante, mussarela, calabresa ralada, pimenta calabresa, azeitonas e orégano.",
                            Preco = 21m,
                            ProdutoID = 4,
                            Promocao = true,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,

                            Logo = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-pizza-baiana-0.jpg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA BRASILEIRA",
                            Descricao = "Molho de tomate, mussarela, calabresa picada, palmito, champignon, azeitonas e orégano.",
                            Preco = 28m,
                            ProdutoID = 5,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            Promocao = true,
                            Logo = "https://img.cybercook.com.br/receitas/549/pizza-sabor-brasileira-da-pizza-hut.jpeg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA FRANGO COM CATUPIRY",
                            Descricao = "Molho de tomate, mussarela, frango desfiado, milho verde, azeitonas, catupiry e orégano.",
                            Preco = 29m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            ProdutoID = 6,
                            Logo = "https://static.clubedaanamariabraga.com.br/wp-content/uploads/2019/02/pizza-de-frango-com-catupiry-18845.jpg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA MARGUERITA",
                            Descricao = "Molho de tomate, mussarela, tomates fatiados, azeitonas, manjericão e orégano.",
                            Preco = 22.50m,
                            ProdutoID = 7,
                            CategoriaProdutoId = 1,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            Logo = "https://static.baratocoletivo.com.br/2018/1105/oferta_15414520984725_OFERTA.jpg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA PORTUGUESA",
                            Descricao = "Molho de tomate, mussarela, presunto, ovos, cebolas, pimentão, azeitona e orégano.",
                            Preco = 27m,
                            ProdutoID = 8,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            Logo = "https://pizzariameurancho.com.br/wp-content/uploads/2016/06/pizza-portuguesa_min.jpg",
                        },
                        new Produto
                        {
                            Nome = "PIZZA TOSCANA",
                            Descricao = " Molho de tomate, mussarela, calabresa picada, bacon em cubos, ovos, catupiry, azeitona e orégano.",
                            Preco = 28m,
                            ProdutoID = 9,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 1,
                            Promocao = true,
                            Logo = "http://www.redelevepizza.com.br/assets/imagens/pizzas/060/toscana.jpg",
                        },
                        new Produto
                        {
                            Nome = "Coca Cola 1 Litro",
                            Logo = "https://hiperideal.vteximg.com.br/arquivos/ids/185619-1000-1000/1485989.jpg?v=637359421330200000",
                            ProdutoID = 10,
                            TipoProduto = Helps.Enum.ProdutoEnum.Bebidas,
                            CategoriaProdutoId = 2,
                            Preco = 6.00M
                        },
                        new Produto
                        {
                            Nome = "Coca Cola Lata 350ml",
                            Logo = "https://trimais.vteximg.com.br/arquivos/ids/1019739-1000-1000/foto_original.jpg?v=637484817261270000",
                            ProdutoID = 11,
                            TipoProduto = Helps.Enum.ProdutoEnum.Bebidas,
                            CategoriaProdutoId = 2,
                            Preco = 4.00M
                        },
                        new Produto
                        {
                            Nome = "Guaraná 1 Litro",
                            Logo = "https://www.imigrantesbebidas.com.br/bebida/images/products/full/4614_Refrigerante_Guarana_Antartica_Pet_1L.jpg",
                            ProdutoID = 12,
                            CategoriaProdutoId = 2,
                            TipoProduto = Helps.Enum.ProdutoEnum.Bebidas,
                            Preco = 5.00M
                        },
                        new Produto
                        {
                            Nome = "Pepsi 1 Litro",
                            Logo = "https://reidoacarajeilheus.com.br/wp-content/uploads/2020/07/download-1-scaled.jpeg",
                            ProdutoID = 13,
                            CategoriaProdutoId = 2,
                            TipoProduto = Helps.Enum.ProdutoEnum.Bebidas,
                            Preco = 6.00M
                        },
                        new Produto
                        {
                            Nome = "Vinho Quinta Do Morgado 1 Litro",
                            Logo = "https://www.imigrantesbebidas.com.br/bebida/images/products/full/6849_Vinho_Quinta_do_Morgado_Tinto_Suave_750_ml.jpg",
                            ProdutoID = 14,
                            TipoProduto = Helps.Enum.ProdutoEnum.BebidasAlcoolicas,
                            CategoriaProdutoId = 2,
                            Promocao = true,
                            Preco = 13.00M
                        },
                        new Produto
                        {
                            Nome = "Vale Verde 12 anos",
                            Logo = "https://images-americanas.b2w.io/produtos/01/00/img/1896394/7/1896394726_1GG.jpg",
                            ProdutoID = 15,
                            CategoriaProdutoId = 2,
                            TipoProduto = Helps.Enum.ProdutoEnum.BebidasAlcoolicas,
                            Preco = 959.00M,
                        },
                        new Produto
                        {
                            Nome = "Combo Eu e Ela",
                            Descricao = "01 Pizza M 6 Fatias + 01 Porção de batata 400g + 01 Refigerante 1 L",
                            Preco = 34.99M,
                            ProdutoID = 16,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 3,
                            Logo = "https://plataforma.ofertaseasyfood.com.br/uploads/art-and-pizza-combo-ofertas-easy-food-londrina.png",
                        },
                        new Produto
                        {
                            Nome = "Combo Eu e Mamãe",
                            Descricao = "01 Pizza M 4 Fatias + 01 Porção de batata + 01 Refigerante em lata",
                            Preco = 29.99M,
                            CategoriaProdutoId = 3,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            ProdutoID = 17,
                            Logo = "https://img.riomarevoce.com/shoppingjardinsonline/2020/06/combo-pizza-doce.png",
                        },
                        new Produto
                        {
                            Nome = "Combo Gostosura",
                            Descricao = "04 Esfirras abertas  + 01 Porção de batata 400g + 01 Refigerante 1 L",
                            Preco = 29.99M,
                            ProdutoID = 18,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 3,
                            Logo = "http://pizzariacolonial.com.br/assets/images/menu/combo_esfiha.png",
                        },
                        new Produto
                        {
                            Nome = "Combo Eu e Ela",
                            Descricao = "01 Pizza M 6 Fatias + 01 Porção de batata 400g + 01 Refigerante 1 L",
                            Preco = 34.99M,
                            CategoriaProdutoId = 3,
                            ProdutoID = 19,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            Logo = "https://pbs.twimg.com/media/DygpbRKWwAAugBY.jpg",
                        },
                        new Produto
                        {
                            Nome = "400 G. Mini Coxinha No Copo",
                            Descricao = "Promoção imperdível, mini coxinhas no copo pelo metade do preço.",
                            Logo = "https://i.pinimg.com/originals/bd/8a/e9/bd8ae947e218a001e8767d6d2d27581a.jpg",
                            Preco = 10.00M,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 4,
                            ProdutoID = 20,
                        },
                        new Produto
                        {
                            Nome = "Batata Frita",
                            Logo = "https://s2.glbimg.com/6TYFXwek9ZpNXFeOzas09KizMKk=/0x0:1280x853/924x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_e84042ef78cb4708aeebdf1c68c6cbd6/internal_photos/bs/2020/T/K/Hh8h2GR96v392DAkAqyA/912c9713-321e-4dfd-bca9-888c05c5ce50.jpeg",
                            Preco = 10.00M,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 4,
                            ProdutoID = 21,
                        },
                        new Produto
                        {
                            Nome = "Carne De Sol Com Fritas",
                            Logo = "https://media-cdn.tripadvisor.com/media/photo-s/0c/87/4a/b7/gg-bar-restaurante.jpg",
                            Preco = 25.00M,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 4,
                            Promocao = true,
                            ProdutoID = 22,
                        },
                        new Produto
                        {
                            Nome = "Mini Coxinha No Copo 400g",
                            Descricao = "Promoção imperdível, mini coxinhas no copo pelo metade do preço.",
                            Logo = "https://www.opcaomassasesalgados.com.br/salgados-para-festa-e-eventos/imagens/valor-de-mini-coxinha.jpg",
                            Preco = 10.00M,
                            TipoProduto = Helps.Enum.ProdutoEnum.Lanche,
                            CategoriaProdutoId = 4,
                            ProdutoID = 23,
                            Promocao = true,
                        },
                        new Produto
                        {
                            Nome = " PIZZA CALABRESA",
                            Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                            Preco = 24m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            Promocao = true,
                            ProdutoID = 24,
                        },
                        new Produto
                        {
                            Nome = " PIZZA CALABRESA",
                            Descricao = "Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.",
                            Preco = 22m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 25,
                        },
                        new Produto
                        {
                            Nome = "PIZZA BACON",
                            Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                            Preco = 20.0m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                             CategoriaProdutoId = 5,
                            ProdutoID = 26,
                        },
                        new Produto
                        {
                            Nome = " PIZZA BAIANA",
                            Descricao = "Molho picante, mussarela, calabresa ralada, pimenta calabresa, azeitonas e orégano.",
                            Preco = 21m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 27,
                        },
                        new Produto
                        {
                            Nome = "PIZZA BRASILEIRA",
                            Descricao = "Molho de tomate, mussarela, calabresa picada, palmito, champignon, azeitonas e orégano.",
                            Preco = 28m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 28,
                        },
                        new Produto
                        {
                            Nome = "PIZZA FRANGO COM CATUPIRY",
                            Descricao = "Molho de tomate, mussarela, frango desfiado, milho verde, azeitonas, catupiry e orégano.",
                            Preco = 29m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 29,
                        },
                        new Produto
                        {
                            Nome = "PIZZA MARGUERITA",
                            Descricao = "Molho de tomate, mussarela, tomates fatiados, azeitonas, manjericão e orégano.",
                            Preco = 22.50m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 30,
                        },
                        new Produto
                        {
                            Nome = "PIZZA PORTUGUESA",
                            Descricao = "Molho de tomate, mussarela, presunto, ovos, cebolas, pimentão, azeitona e orégano.",
                            Preco = 27m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            ProdutoID = 31,
                        },
                        new Produto
                        {
                            Nome = "PIZZA TOSCANA",
                            Descricao = " Molho de tomate, mussarela, calabresa picada, bacon em cubos, ovos, catupiry, azeitona e orégano.",
                            Preco = 28m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 5,
                            Promocao = true,
                            ProdutoID = 32,
                        },
                        new Produto
                        {
                             Nome = " PIZZA CALABRESA",
                             Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                             Preco = 24m,
                             TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                             CategoriaProdutoId = 6,
                             Promocao = true,
                             ProdutoID =33,
                        },
                        new Produto
                        {
                            Nome = " PIZZA CALABRESA",
                            Descricao = "Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.",
                            Preco = 22m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            Promocao = true,
                            ProdutoID = 34,
                        },
                        new Produto
                        {
                            Nome = "PIZZA BACON",
                            Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                            Preco = 20.0m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            Promocao = true,
                            ProdutoID = 35,
                        },
                        new Produto
                        {
                            Nome = " PIZZA BAIANA",
                            Descricao = "Molho picante, mussarela, calabresa ralada, pimenta calabresa, azeitonas e orégano.",
                            Preco = 21m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            ProdutoID = 36,
                        },
                        new Produto
                        {
                            Nome = "PIZZA BRASILEIRA",
                            Descricao = "Molho de tomate, mussarela, calabresa picada, palmito, champignon, azeitonas e orégano.",
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            Preco = 28m,
                            CategoriaProdutoId = 6,
                            ProdutoID = 37,
                        },
                        new Produto
                        {
                            Nome = "PIZZA FRANGO COM CATUPIRY",
                            Descricao = "Molho de tomate, mussarela, frango desfiado, milho verde, azeitonas, catupiry e orégano.",
                            Preco = 29m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            ProdutoID = 38,
                        },
                        new Produto
                        {
                            Nome = "PIZZA MARGUERITA",
                            Descricao = "Molho de tomate, mussarela, tomates fatiados, azeitonas, manjericão e orégano.",
                            Preco = 22.50m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            ProdutoID = 39,
                        },
                        new Produto
                        {
                            Nome = "PIZZA PORTUGUESA",
                            Descricao = "Molho de tomate, mussarela, presunto, ovos, cebolas, pimentão, azeitona e orégano.",
                            Preco = 27m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            Promocao = true,
                            ProdutoID = 40,
                        },
                        new Produto
                        {
                            Nome = "PIZZA TOSCANA",
                            Descricao = " Molho de tomate, mussarela, calabresa picada, bacon em cubos, ovos, catupiry, azeitona e orégano.",
                            Preco = 28m,
                            TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                            CategoriaProdutoId = 6,
                            ProdutoID = 41,
                        },
                         new Produto
                               {
                                   Nome = " PIZZA CALABRESA",
                                   Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                                   Preco = 24m,
                                   CategoriaProdutoId = 7,
                                   ProdutoID = 42,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                               },
                               new Produto
                               {
                                   Nome = " PIZZA CALABRESA",
                                   Descricao = "Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.",
                                   Preco = 22m,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   CategoriaProdutoId = 7,
                                   Promocao = true,
                                   ProdutoID = 43,
                               },
                               new Produto
                               {
                                   Nome = "PIZZA BACON",
                                   Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                                   Preco = 20.0m,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   CategoriaProdutoId = 7,
                                   ProdutoID = 44,
                               },
                               new Produto
                               {
                                   Nome = " PIZZA BAIANA",
                                   Descricao = "Molho picante, mussarela, calabresa ralada, pimenta calabresa, azeitonas e orégano.",
                                   Preco = 21m,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   CategoriaProdutoId = 7,
                                   ProdutoID =45,
                               },
                               new Produto
                               {
                                   Nome = "PIZZA BRASILEIRA",
                                   Descricao = "Molho de tomate, mussarela, calabresa picada, palmito, champignon, azeitonas e orégano.",
                                   Preco = 28m,
                                   CategoriaProdutoId = 7,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   ProdutoID =46,
                               },
                               new Produto
                               {
                                   Nome = "PIZZA FRANGO COM CATUPIRY",
                                   Descricao = "Molho de tomate, mussarela, frango desfiado, milho verde, azeitonas, catupiry e orégano.",
                                   Preco = 29m,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   CategoriaProdutoId = 7,
                                   ProdutoID = 47,
                               },
                               new Produto
                               {
                                   Nome = "PIZZA MARGUERITA",
                                   Descricao = "Molho de tomate, mussarela, tomates fatiados, azeitonas, manjericão e orégano.",
                                   Preco = 22.50m,
                                   CategoriaProdutoId = 7,
                                   ProdutoID = 48,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,

                               },
                               new Produto
                               {
                                   Nome = "PIZZA PORTUGUESA",
                                   Descricao = "Molho de tomate, mussarela, presunto, ovos, cebolas, pimentão, azeitona e orégano.",
                                   Preco = 27m,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                                   CategoriaProdutoId = 7,
                                   Promocao = true,
                                   ProdutoID = 49,

                               },
                               new Produto
                               {
                                   Nome = "PIZZA TOSCANA",
                                   Descricao = " Molho de tomate, mussarela, calabresa picada, bacon em cubos, ovos, catupiry, azeitona e orégano.",
                                   Preco = 28m,
                                   CategoriaProdutoId = 7,
                                   ProdutoID = 50,
                                   TipoProduto = Helps.Enum.ProdutoEnum.Pizza,
                               },
                #region Sobra
                //  new Produto
                //{
                //    Nome = " PIZZA CALABRESA",
                //    Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                //    Preco = 24m,
                //    CategoriaProdutoId = 7,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = " PIZZA CALABRESA",
                //    Descricao = "Molho de tomate, mussarela, calabresa fatiada, cebola e orégano.",
                //    Preco = 22m,

                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA BACON",
                //    Descricao = "Molho de tomate, mussarela, camada dupla de catupiry e orégano.",
                //    Preco = 20.0m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = " PIZZA BAIANA",
                //    Descricao = "Molho picante, mussarela, calabresa ralada, pimenta calabresa, azeitonas e orégano.",
                //    Preco = 21m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA BRASILEIRA",
                //    Descricao = "Molho de tomate, mussarela, calabresa picada, palmito, champignon, azeitonas e orégano.",
                //    Preco = 28m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA FRANGO COM CATUPIRY",
                //    Descricao = "Molho de tomate, mussarela, frango desfiado, milho verde, azeitonas, catupiry e orégano.",
                //    Preco = 29m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA MARGUERITA",
                //    Descricao = "Molho de tomate, mussarela, tomates fatiados, azeitonas, manjericão e orégano.",
                //    Preco = 22.50m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA PORTUGUESA",
                //    Descricao = "Molho de tomate, mussarela, presunto, ovos, cebolas, pimentão, azeitona e orégano.",
                //    Preco = 27m,
                //    ProdutoID = 8,
                //},
                //new Produto
                //{
                //    Nome = "PIZZA TOSCANA",
                //    Descricao = " Molho de tomate, mussarela, calabresa picada, bacon em cubos, ovos, catupiry, azeitona e orégano.",
                //    Preco = 28m,
                //    ProdutoID = 8,
                //},
#endregion
            };
            return ListProdutos;
        }
    }

}
