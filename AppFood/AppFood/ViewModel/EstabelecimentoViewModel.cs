using AppFooD.Models;
using AppFooD.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class EstabelecimentoViewModel : BaseViewModel
    {
        private List<Estabelecimento> _ListEstabelecimento;
        public List<Estabelecimento> ListEstabelecimento
        {
            get { return _ListEstabelecimento; }
            set { SetProperty(ref _ListEstabelecimento, value); }
        }

        private string _SearchWord;
        public string SearchWord
        {
            get { return _SearchWord; }
            set
            {
                SetProperty(ref _SearchWord, value);
                if (value != null)
                {
                    BuscarEstabelecimento();
                }
            }
        }

        private List<Estabelecimento> _TodosEstabelecimento;
        public List<Estabelecimento> TodosEstabelecimento
        {
            get { return _TodosEstabelecimento; }
            set { SetProperty(ref _TodosEstabelecimento, value); }
        }
        //public ICommand ChamarTelaPedidosCommand { get; set; }
        public ICommand ExibirEstabelecimentoCommand { get; set; }
        public ICommand ChamarTelaHomeCommand { get; set; }
        public ICommand ChamarTelaConfigUserCommand { get; set; }
        public EstabelecimentoViewModel()
        {
            TodosEstabelecimento = new EstabelecimentoServices().GetEstabelecimentos().ToList();

            ListEstabelecimento = new List<Estabelecimento>(TodosEstabelecimento);
            //ListEstabelecimento.CollectionChanged += ListEstabelecimento_CollectionChanged;
        }

        public void BuscarEstabelecimento()
        {
            if (SearchWord != "")
            {
                ListEstabelecimento = ListEstabelecimento.Where(a => a.Nome.ToLower().Contains(SearchWord.ToLower())).ToList();
                //(List<Estabelecimento>)ListEstabelecimento = list;
            }
            else
            {
                ListEstabelecimento = new List<Estabelecimento>(TodosEstabelecimento);
            }
        }

    }


}
