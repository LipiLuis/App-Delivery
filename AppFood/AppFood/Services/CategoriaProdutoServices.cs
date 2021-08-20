using AppFooD.Models;
using System.Collections.Generic;

namespace AppFooD.Services
{
    public class CategoriaProdutoServices
    {
        public List<CategoriaProduto> GetCategoriaProdutos()
        {
            return new List<CategoriaProduto>()
            {

                new CategoriaProduto
                {
                    Nome = "Pizza",
                    EmpresaId = 1,
                    CategoriaProdutoId = 1,
                    Logo = "https://www.alegrafoods.com.br/wp-content/uploads/2020/07/9-img-blog.png",

                },
                new CategoriaProduto
                {
                    Nome = "BEBIDAS",
                    EmpresaId = 1,
                    Logo = "https://super.abril.com.br/wp-content/uploads/2018/02/ressaca-c3a9-pior-quando-vocc3aa-mistura-bebidas.png",
                    CategoriaProdutoId = 2 ,
                },
                new CategoriaProduto
                {
                    Nome = "COMBOS ESPECIAIS",
                    EmpresaId = 1,
                    Logo = "https://portaldeamericana.com/wp-content/uploads/2018/05/roots-1.jpg",
                    CategoriaProdutoId = 3,
                },
                new CategoriaProduto
                {
                    Nome = "PESTISCOS",
                    EmpresaId = 1,
                    CategoriaProdutoId = 4 ,
                    Logo = "https://pbs.twimg.com/media/EOb2xt8WsAoUkpK.jpg",
                },
                new CategoriaProduto
                {
                    EmpresaId = 2,
                    Nome = "Pizza",
                    Logo = "https://www.alegrafoods.com.br/wp-content/uploads/2020/07/9-img-blog.png",
                    CategoriaProdutoId = 5,
                },
                new CategoriaProduto
                {
                   EmpresaId = 3,
                   Nome = "Pizza",
                   CategoriaProdutoId = 6,
                   Logo = "https://www.alegrafoods.com.br/wp-content/uploads/2020/07/9-img-blog.png",

                },
                new CategoriaProduto
                {
                   EmpresaId = 4,
                   Nome = "Pizza",
                   CategoriaProdutoId = 7,
                   Logo = "https://www.alegrafoods.com.br/wp-content/uploads/2020/07/9-img-blog.png",
                },
            };
        }
    }
}
