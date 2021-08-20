using AppFooD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Models
{
    public class AccountUser
    {
        public int AccountID { get; set; }
        public string Foto { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Numero { get; set; }
        public string Senha { get; set; }
        public bool Logado { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
