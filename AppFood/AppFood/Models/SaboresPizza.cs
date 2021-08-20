using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Models
{
   public class SaboresPizza
    {
        public int Codigo { get; set; }
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public SaboresPizza()
        {

        }

        public SaboresPizza(int codigo, int codigoProduto, string nome, decimal preco)
        {
            Codigo = codigo;
            CodigoProduto = codigoProduto;
            Nome = nome;
            Preco = preco;
        }
    }
}
