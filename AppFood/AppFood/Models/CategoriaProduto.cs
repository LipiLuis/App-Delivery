using System.Collections.Generic;

namespace AppFooD.Models
{
    public class CategoriaProduto
    {

        public int CategoriaProdutoId { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        private int _EmpresaId;
        public int EmpresaId
        {
            get { return _EmpresaId; }
            set
            {
                _EmpresaId = value;
            }
        }



    }
}